using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Locked,
            Pending,
            Failed,
            Active,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double HardEditor = 65.3;
        public const long MinEditor = 6997;
        public const long IdleScore = 8980;
        public const long MaxSize = 7705;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
