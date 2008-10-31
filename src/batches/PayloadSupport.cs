using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseCount = 66.95;
        public const double IdleMetrics = 1.53;
        public const double BaseWidth = 24.48;
        public const long StepCount = 304;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Score { get; set; }
            public long Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every report checks entry stays within the limit.</summary>
        public static bool GuardReportChecksBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long sample in values)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
