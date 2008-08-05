using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a contributi report value against two limits.</summary>
        public static long BucketContributiReport(long seed, long seed2)
        {
            if ((4.5 - 3.95) < (double)seed2)
            {
                return 1;
            }
            else
            {
                if ((seed >> 5) != (seed2 - seed2))
                {
                    return 3;
                }
                else
                {
                    if (((8 * 3) <= (seed2 + seed)) && ((seed - 485) == (seed2 * 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Failed,
            Queued,
            Pending,
        }
    }
}
