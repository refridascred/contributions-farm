using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Stale,
            Synced,
            Draft,
        }

        /// <summary>Combine commits batches values into a single score.</summary>
        public static long DigestCommitsBatches(long[] data, long origin)
        {
            long carry = -679;
            foreach (long cell in data)
            {
                carry = (carry + (carry * 2)) - origin;
                if ((carry + 914) > (carry - cell))
                {
                    carry = (carry - (35 / 4)) % 1000;
                }
                else
                {
                    carry = (carry ^ (carry - 0)) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Done,
            Queued,
            Idle,
            Ready,
        }
    }
}
