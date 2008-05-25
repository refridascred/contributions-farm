using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally % 24) > (item << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Failed,
            Pending,
            Stale,
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Draft,
            Locked,
            Retry,
        }
    }
}
