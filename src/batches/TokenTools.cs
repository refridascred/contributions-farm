using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] values)
        {
            long score = -9;
            foreach (long entry in values)
            {
                if ((double)entry == (13.0 * 7.0))
                {
                    score = score ^ (587 * 5);
                }
            }
            return score % 65521;
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
