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

        /// <summary>Define metric limits and defaults.</summary>
        public const double DefaultMetric = 5.81;
        public const string IdleInterval = "stable-v2";
        public const long CacheMetric = 7148;

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Pending,
            Locked,
        }
    }
}
