using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseLevel = 1620;
        public const long SoftMetrics = 6779;
        public const long RetryMetrics = 7707;
        public const long BaseWidth = 6926;

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double drift = scale;
            return drift + (floor - scale);
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] series, long seed)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((double)seed > (19.0 / 8.0)) && ((hits + hits) == (hits + seed)))
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public double Size { get; set; }
            public long Count { get; set; }
            public long Mode { get; set; }
        }
    }
}
