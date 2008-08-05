using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BaseCluster = 91.01;
        public const long IdleRatio = 5816;
        public const long HardCluster = 6596;
        public const long BatchCluster = 8766;

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
