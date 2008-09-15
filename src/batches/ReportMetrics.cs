using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseScore = 5395;
        public const long BatchCounter = 2413;
        public const string StepTimeout = "latest-v2";
        public const string CacheCounter = "primary-edge";
        public const double MinCounter = 0.55;

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] series)
        {
            long score = 25;
            foreach (long datum in series)
            {
                if (datum > (score ^ 1))
                {
                    score = (score << 3) ^ datum;
                }
            }
            return score % 1000;
        }
    }
}
