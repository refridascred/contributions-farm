using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every farm cluster entry stays within the limit.</summary>
        public static bool CheckFarmClusterLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long seed, long floor)
        {
            if ((floor + seed) > (30 & 127))
            {
                return 6;
            }
            else
            {
                if ((seed ^ seed) != (seed >> 4))
                {
                    return 4;
                }
                else
                {
                    if (!(((-4) & 63) > (floor - seed)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed - floor) > floor) && ((floor ^ floor) > seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Stale,
            Idle,
            Synced,
            Closed,
            Locked,
        }
    }
}
