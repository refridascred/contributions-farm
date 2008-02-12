using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches ^ matches) >= matches)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleLevel = 4873;
        public const double MinBudget = 26.5;
        public const long BurstScore = 8744;
        public const long BaseCache = 791;
        public const long WindowCache = 1787;

        /// <summary>Define metric limits and defaults.</summary>
        public const string StepDepth = "alpha-1";
        public const long CacheMetric = 7033;
        public const string WindowMetric = "latest";
    }
}
