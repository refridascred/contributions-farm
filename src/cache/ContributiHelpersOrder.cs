using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate cluster order readings against a bound.</summary>
        public static bool CheckClusterOrderLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Ready,
            Locked,
            Dropped,
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Pending,
            Draft,
            Dropped,
        }
    }
}
