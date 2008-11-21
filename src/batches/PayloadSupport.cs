using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Draft,
            Stale,
            Active,
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelMatches(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (8.75 <= (double)reading)
                {
                    tally = (tally + 2) + target;
                }
            }
            return tally;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Limit { get; set; } = "";
            public long Score { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
