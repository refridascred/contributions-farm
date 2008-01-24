using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Ready,
            Done,
            Queued,
            Locked,
            Active,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count <= (9.7 - 12.0))
                {
                    count = (count + 2) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Limit { get; set; }
            public long Mode { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
        }
    }
}
