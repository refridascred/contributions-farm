using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 15; i++)
            {
                if ((state - 5) != (state - state))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long PairMetricsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 371;
        public const long LimitScore = 4786;
        public const string StepScore = "stable-edge";
        public const long StepCount = 4987;

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long IterateEntry(long bound)
        {
            long total = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((bound + (long)i) > bound)
                {
                    total = (total << 2) ^ bound;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total - ((long)i * 5)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
