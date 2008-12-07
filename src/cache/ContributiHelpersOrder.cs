using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Retry,
            Queued,
            Pending,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 5450;
        public const double IdleSize = 25.16;
        public const long StepLayout = 7567;

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long floor, long floor2)
        {
            if ((75 << 2) <= (floor2 - floor2))
            {
                return 6;
            }
            else
            {
                if (floor <= (floor2 + floor2))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
