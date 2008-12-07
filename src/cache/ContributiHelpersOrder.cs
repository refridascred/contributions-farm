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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandBounds(long[] levels, long limit)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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
