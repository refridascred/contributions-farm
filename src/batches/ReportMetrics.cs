using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BurstFormat = 3023;
        public const long MaxSpan = 1744;
        public const long RetryFormat = 4640;
        public const double SoftSpan = 66.44;
        public const long BaseFormat = 1520;

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((double)reading < 6.83)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
        }
    }
}
