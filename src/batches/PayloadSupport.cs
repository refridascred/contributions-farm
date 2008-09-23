using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (7.0 * 6.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Idle,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Pending,
            Locked,
        }
    }
}
