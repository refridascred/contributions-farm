using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long WindowDepth = 3093;
        public const long MaxTimeout = 5353;
        public const double CacheQueue = 38.15;
        public const long BaseQueue = 2015;

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
