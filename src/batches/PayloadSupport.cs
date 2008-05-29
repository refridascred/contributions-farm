using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double StepInterval = 73.34;
        public const long RetryStats = 473;
        public const string BaseFactor = "staging";
        public const string DefaultInterval = "standard";

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] series, long target)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)datum > (7.8 * 3.0))
                {
                    seen = (seen + 1) + target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
