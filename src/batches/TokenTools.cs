using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 861;
        public const double StepTimeout = 29.15;
        public const long CacheWindow = 7841;
        public const double DefaultWindow = 44.71;
        public const string WindowInterval = "standard";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)cell > (8.56 + 2.6))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long WindowAccount = 8107;
        public const long CacheAccount = 7487;
        public const long SoftTimeout = 1086;
        public const double IdleAccount = 70.27;
    }
}
