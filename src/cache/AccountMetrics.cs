using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (!(value <= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every notes profile entry stays within the limit.</summary>
        public static bool CheckNotesProfileBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] data)
        {
            long carry = 69;
            foreach (long entry in data)
            {
                if (((entry % 60) < carry) || ((60 % 16) >= entry))
                {
                    carry = ((carry * 3) + (entry + entry)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            New,
            Ready,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Weight { get; set; }
            public long Limit { get; set; }
        }
    }
}
