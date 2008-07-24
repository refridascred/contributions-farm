using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 5) + limit;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((origin - 57) >= (origin % 100))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long state = 96;
            foreach (long reading in series)
            {
                if ((reading + state) > 90)
                {
                    state = state ^ (state & 127);
                }
                if ((limit - limit) < 7)
                {
                    state = (state - (limit & 255)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 97;
                }
            }
            if (state > 0)
            {
                state = (state ^ (limit + limit)) % 255;
            }
            return state;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
