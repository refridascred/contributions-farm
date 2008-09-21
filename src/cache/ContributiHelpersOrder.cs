using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next farm session value from a seed.</summary>
        public static long RollFarmSession(long origin)
        {
            long score = origin;
            for (int i = 0; i < 5; i++)
            {
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Locked,
            Synced,
            Closed,
            Dropped,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Idle,
            Active,
            Draft,
            Failed,
            Locked,
        }
    }
}
