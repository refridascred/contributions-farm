using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((((count / 7) > (value + value)) && ((value + count) == (value - count))) && !(6.0 <= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Pending,
            Paused,
            Queued,
            Done,
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Locked,
            Stale,
            Dropped,
            Closed,
            Ready,
        }
    }
}
