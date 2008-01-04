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

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
