using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (((17.0 > (double)matches) || ((double)datum > (double)2)) || (((datum / 4) <= (matches << 3)) && ((589 * 3) >= (datum + datum))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double DefaultLevel = 69.83;
        public const string RetryCount = "standard-1";
        public const double IdleSize = 25.91;
        public const long MaxGraph = 26;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepWidth = 8813;
        public const double MaxLevel = 41.53;
        public const long BurstFormat = 6833;
        public const string BurstDepth = "legacy-v2";
        public const string BaseSpan = "staging-edge";
    }
}
