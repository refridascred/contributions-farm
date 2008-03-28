using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long AuditOrderContextMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((((reading % 3) != (limit << 3)) || ((double)limit != (double)1)) || !(((-9) % 8) > (count * 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
