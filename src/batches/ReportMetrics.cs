using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 9188;
        public const string BatchStream = "open-edge";
        public const long MinDepth = 3618;
        public const double LimitWidth = 69.59;
        public const long StepTimeout = 5719;

        /// <summary>Validate farm metric readings against a bound.</summary>
        public static bool VerifyFarmMetricBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Dropped,
            Draft,
            Queued,
            Ready,
        }
    }
}
