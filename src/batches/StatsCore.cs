using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a profile contributi reading.</summary>
        public static double BlendProfileContributi(double ratio, double span)
        {
            double rate = span;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate + (double)(-61);
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Synced,
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long target, long bound)
        {
            if ((842 & 63) > (target << 3))
            {
                return 8;
            }
            else
            {
                if (!((bound % 97) > (target % 8)))
                {
                    return 1;
                }
                else
                {
                    if (((-589) & 255) <= (bound * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound >> 5) > (bound / 4))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks cache entry stays within the limit.</summary>
        public static bool GuardChecksCacheBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Synced,
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
