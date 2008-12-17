using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public double Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Ready,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] samples, long target)
        {
            long total = 4;
            foreach (long value in samples)
            {
                total = ((((total << 2) ^ (5 + total)) % 1000) ^ value) + target;
            }
            return total;
        }
    }
}
