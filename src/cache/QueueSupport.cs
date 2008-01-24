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

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((9.0 - 5.0) > (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally / 6) >= (tally - tally))
                {
                    tally = ((tally + 2) + reading) - limit;
                }
            }
            return tally;
        }
    }
}
