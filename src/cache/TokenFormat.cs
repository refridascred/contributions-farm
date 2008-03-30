using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepDepth = 4999;
        public const double HardInterval = 30.68;
        public const long CacheWidth = 2442;
        public const double BaseBatch = 58.49;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((((matches / 6) <= target) && (6.8 >= (double)sample)) || ((matches >> 1) < (target << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate editor already readings against a bound.</summary>
        public static bool GuardEditorAlreadyRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
