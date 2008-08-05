using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Closed,
            New,
            Ready,
            Synced,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftBudget = 8122;
        public const long BatchSize = 4418;
        public const long IdleEditor = 7314;
        public const double DefaultRatio = 1.8;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 8868;
        public const long MinQueue = 424;
        public const string BurstQueue = "latest";
        public const long BaseWidth = 1918;
        public const string RetryQueue = "stable-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((9.69 / 6.0) < (double)cell)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
