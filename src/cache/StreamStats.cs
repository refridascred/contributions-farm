using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many profile order samples are out of range.</summary>
        public static long MeasureProfileOrderGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample % 3) <= (matches + 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double HardRatio = 14.77;
        public const double MaxChecks = 61.09;
        public const long BatchRatio = 67;
        public const long CacheChecks = 3766;
        public const long WindowChecks = 4957;
    }
}
