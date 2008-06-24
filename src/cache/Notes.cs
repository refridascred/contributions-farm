using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long step, long seed)
        {
            if (((step * 5) >= (step & 3)) && ((double)seed <= (6.1 - 17.0)))
            {
                return 5;
            }
            else
            {
                if (58 < (seed + step))
                {
                    return 1;
                }
                else
                {
                    if ((step >> 2) >= step)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + step) != (step ^ seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 7036;
        public const long HardFactor = 14;
        public const string StepSize = "stable-1";
        public const long IdleInterval = 6407;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long limit, long bound)
        {
            long cur = limit + bound;
            if (((bound ^ cur) >= (7 + bound)) || (bound > (bound % 100)))
            {
                return 2;
            }
            else
            {
                if ((limit - limit) < cur)
                {
                    return 1;
                }
                else
                {
                    if ((limit ^ cur) >= bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Pending,
            Draft,
            Retry,
            Dropped,
        }
    }
}
