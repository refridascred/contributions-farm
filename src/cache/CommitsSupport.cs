using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a batches window value against two limits.</summary>
        public static long SortBatchesWindow(long target, long floor)
        {
            long step = target - floor;
            if ((step << 3) >= target)
            {
                return 3;
            }
            else
            {
                if (5.56 >= (double)step)
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Active,
            Retry,
            New,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Ready,
            Failed,
            Active,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long offset, long origin)
        {
            if (((origin / 6) > (578 & 63)) && ((origin ^ origin) != (offset % 60)))
            {
                return 6;
            }
            else
            {
                if (!((double)offset < 3.1))
                {
                    return 0;
                }
                else
                {
                    if (!((offset * 4) <= 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((3.0 < (double)offset) && ((origin * 2) != (offset + offset)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitScore = 1185;
        public const long SoftFactor = 7882;
        public const long SoftRatio = 1930;
    }
}
