using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long step, long seed)
        {
            long bound = step - seed;
            if (((bound >> 1) > (step + bound)) && ((seed % 2) <= ((-6) % 10)))
            {
                return 4;
            }
            else
            {
                if (!((double)seed > 1.6))
                {
                    return 3;
                }
                else
                {
                    if ((4.0 / 4.0) <= (double)seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Pending,
            Stale,
            Paused,
            Failed,
        }
    }
}
