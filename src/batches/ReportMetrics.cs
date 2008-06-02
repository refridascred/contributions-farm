using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstBudget = 5385;
        public const long IdleCount = 8468;
        public const long RetryBudget = 5465;
        public const double BatchSchema = 81.48;

        /// <summary>Count the buffer context entries that pass the check.</summary>
        public static long TallyBufferContextHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen ^ seen) == (datum << 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheBudget = 7579;
        public const long BurstWidth = 3955;
        public const long BaseSpan = 3204;
        public const string LimitBatch = "alpha";
    }
}
