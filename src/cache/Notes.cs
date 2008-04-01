using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Token { get; set; } = "";
            public bool Limit { get; set; }
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Closed,
            Draft,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string IdleWidth = "fallback-edge";
        public const double SoftScore = 97.64;
        public const long BaseSize = 4026;

        /// <summary>Adjust a support reading.</summary>
        public static double ProjectSupport(double scale, double floor)
        {
            double bias = (double)(97 + 23);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias + (double)(long)i) - scale) - floor;
            }
            return bias - (double)19;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
        }
    }
}
