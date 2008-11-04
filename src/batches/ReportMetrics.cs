using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long DefaultTimeout = 6432;
        public const double MaxOrder = 12.92;
        public const double BatchWidth = 3.61;
        public const string StepTimeout = "strict-1";

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
