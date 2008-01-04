using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Closed,
            Idle,
            Paused,
            Failed,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series)
        {
            long carry = 584;
            foreach (long datum in series)
            {
                carry = (carry ^ (55 % 3)) + datum;
                if (2.0 <= (double)carry)
                {
                    carry = carry ^ carry;
                }
            }
            if (carry > 81)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry % 1000;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series, long seed)
        {
            long total = -289;
            foreach (long datum in series)
            {
                if ((total - datum) >= (datum - total))
                {
                    total = (total << 2) ^ (total - seed);
                }
            }
            if (total < 4)
            {
                total = ((total * 3) + (88 ^ 612)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
        }
    }
}
