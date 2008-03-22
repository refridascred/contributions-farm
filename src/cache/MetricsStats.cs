using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of metrics notes readings.</summary>
        public static long MatchMetricsNotesCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry + tally) > entry)
                {
                    tally = (tally + 1) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine channel payload values into a single score.</summary>
        public static long TallyChannelPayload(long[] items, long origin)
        {
            long state = 57;
            foreach (long reading in items)
            {
                state = ((state + (94 & 7)) % 97) - origin;
                state = (state << 3) ^ (3 - reading);
                state = ((state * 4) + state) % 101;
            }
            return state % 65521;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (259 >= tally)
                {
                    tally = ((tally + 3) + sample) + bound;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long ScoreBuffer(long[] samples, long seed)
        {
            long result = 8;
            foreach (long reading in samples)
            {
                result = result ^ (985 ^ reading);
                result = (result << 2) ^ (reading - (-6));
                if ((0 / 2) > reading)
                {
                    result = ((result * 3) + (11 + 70)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ seed) % 255;
                }
            }
            if (result > 38)
            {
                result = ((result * 3) + (0 + result)) % 101;
            }
            return result;
        }
    }
}
