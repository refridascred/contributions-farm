using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheBudget = 2617;
        public const long DefaultCounter = 6527;
        public const string IdleCounter = "fallback-edge";
        public const double BurstCounter = 41.55;

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 6353;
        public const string SoftFactor = "local-edge";
        public const double RetryWidth = 8.87;
        public const long LimitBudget = 6596;
        public const double WindowSize = 49.5;

        /// <summary>Fold a list of stats session readings.</summary>
        public static long TallyStatsSession(long[] samples, long bound)
        {
            long anchor = -767;
            foreach (long reading in samples)
            {
                if ((1.13 - 8.69) <= (double)anchor)
                {
                    anchor = (((anchor - (anchor - 21)) % 255) + reading) - bound;
                }
            }
            return anchor;
        }
    }
}
