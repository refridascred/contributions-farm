using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftTimeout = "standard";
        public const long BaseInterval = 1543;
        public const long BatchSpan = 4138;

        /// <summary>Roll a report checks counter forward.</summary>
        public static long DeriveReportChecks(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = carry - (bound ^ bound);
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }
    }
}
