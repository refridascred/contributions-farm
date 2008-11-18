using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 9304;
        public const long BurstRecord = 1221;
        public const double CacheScore = 50.09;
        public const string CacheRecord = "latest";
        public const long DefaultSize = 5917;

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 6500;
        public const long CacheCounter = 4143;
        public const string WindowCounter = "strict-v2";
        public const double SoftInterval = 8.78;
        public const long StepCounter = 4852;

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length + seed) <= 2)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
