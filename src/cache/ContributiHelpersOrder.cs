using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long offset, long target)
        {
            long bound = offset - target;
            if (!(target < (6 / 4)))
            {
                return 0;
            }
            else
            {
                if (((target ^ target) >= target) && ((bound << 3) < (bound ^ offset)))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryFactor = 7458;
        public const string BurstFactor = "strict-1";
        public const long MinMetric = 6380;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Pending,
            New,
            Idle,
            Locked,
            Draft,
        }
    }
}
