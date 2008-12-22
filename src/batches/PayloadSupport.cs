using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-v2";
        public const string LimitAccount = "fallback-v2";
        public const string CacheAccount = "open-v2";
        public const string StepAccount = "cached-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const string BaseSpan = "open-edge";
        public const long DefaultCount = 4946;
        public const double IdleReport = 45.54;
        public const long BatchReport = 3000;

        /// <summary>Roll a counter metric counter forward.</summary>
        public static long DeriveCounterMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!((score * 4) == (offset >> 2)))
                {
                    score = (score - (long)i) % 255;
                }
                else
                {
                    score = score + ((-68) * 3);
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
