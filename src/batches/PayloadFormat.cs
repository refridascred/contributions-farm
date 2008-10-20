using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] levels)
        {
            long state = 0;
            foreach (long entry in levels)
            {
                if (((entry >> 2) < (entry + entry)) && ((state + (-451)) == (state / 8)))
                {
                    state = (state - (state - 14)) % 1000;
                }
                else
                {
                    state = ((state << 2) ^ (entry % 60)) % 101;
                }
            }
            return state;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long MeasureCommandChannelHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((double)item == (3.33 - 2.7))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (!((seed + seed) >= tally))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }
    }
}
