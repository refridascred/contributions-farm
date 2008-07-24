using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Dropped,
            Draft,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public string Total { get; set; } = "";
            public bool Size { get; set; }
            public double Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepTimeout = 3471;
        public const string CacheWidth = "primary-edge";
        public const long HardWidth = 6086;
        public const long DefaultQueue = 8865;
        public const long MinQueue = 2592;
    }
}
