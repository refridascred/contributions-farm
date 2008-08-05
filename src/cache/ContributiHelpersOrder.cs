using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Closed,
            Idle,
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            Queued,
            Closed,
            Pending,
            Dropped,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 2) >= 11)
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
