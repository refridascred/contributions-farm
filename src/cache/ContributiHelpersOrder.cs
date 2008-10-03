using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a farm payload pair into a bucket.</summary>
        public static long ClassifyFarmPayload(long origin, long seed)
        {
            if (((origin + seed) < (0 * 3)) && ((origin / 7) >= (origin ^ seed)))
            {
                return 4;
            }
            else
            {
                if (((seed << 3) == (seed & 1)) || ((seed >> 4) == (30 + seed)))
                {
                    return 5;
                }
                else
                {
                    if (((seed + seed) < (seed - origin)) || (seed > (seed / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Dropped,
            Draft,
            Paused,
            Failed,
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Paused,
            Stale,
            Locked,
            Synced,
        }
    }
}
