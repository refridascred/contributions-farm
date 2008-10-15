using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Paused,
            Closed,
            New,
            Queued,
        }

        /// <summary>Combine metrics commits values into a single score.</summary>
        public static long DigestMetricsCommits(long[] items)
        {
            long carry = 96;
            foreach (long value in items)
            {
                carry = carry + carry;
                if ((value ^ carry) == (carry * 3))
                {
                    carry = ((carry * 4) + (979 - carry)) % 97;
                }
                else
                {
                    carry = (carry - (value % 12)) % 1000;
                }
            }
            if (carry > 1)
            {
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Pending,
            Closed,
            Active,
        }
    }
}
