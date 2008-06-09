using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Queued,
            Ready,
            Stale,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string HardBatch = "stable-edge";
        public const long WindowTimeout = 5720;
        public const long HardInterval = 9109;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen & 7) <= (datum - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
