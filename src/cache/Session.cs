using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total - (offset & 1)) % 1000) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 12; i3++)
                {
                    total = (total ^ (5 * 3)) - (long)i3;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long step)
        {
            if ((bound + (-4)) > bound)
            {
                return 3;
            }
            else
            {
                if (((bound % 16) >= bound) && ((double)step == (0.72 / 3.0)))
                {
                    return 5;
                }
                else
                {
                    if ((step & 1) <= (bound >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 - 8.85) <= (double)bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool GuardSessionBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
