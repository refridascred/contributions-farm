using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 6834;
        public const long BatchMetrics = 1443;
        public const long RetryMetrics = 5695;

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value / 9) < 40)
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheScore = 1051;
        public const long BaseWidth = 1884;
        public const string MinStats = "local-v2";
        public const double DefaultFactor = 1.43;
        public const long HardInterval = 9916;
    }
}
