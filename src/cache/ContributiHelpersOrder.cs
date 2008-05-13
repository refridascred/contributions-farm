using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] samples, long offset)
        {
            long mark = 945;
            foreach (long item in samples)
            {
                if ((double)7 <= (double)mark)
                {
                    mark = ((mark + (mark & 31)) % 255) - item;
                }
                if (((offset * 3) > mark) || ((mark + 27) < (mark & 3)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 5820;
        public const long HardMetric = 9556;
        public const string BatchMetric = "stable-1";
        public const string LimitSize = "fallback-v2";
        public const double SoftWidth = 84.47;

        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseSpan = 2909;
        public const double LimitGraph = 29.28;
        public const string BatchGraph = "open-1";
        public const long HardWidth = 4625;
        public const string CacheGraph = "cached-1";
    }
}
