using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Active,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Rank queue payload input into a small class.</summary>
        public static long BucketQueuePayload(long floor, long floor2)
        {
            if ((double)475 > (double)floor2)
            {
                return 6;
            }
            else
            {
                if ((floor % 24) >= (floor2 ^ floor))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long origin, long origin2)
        {
            long gap = origin - origin2;
            if ((gap * 4) >= gap)
            {
                return 8;
            }
            else
            {
                if ((origin2 - origin) != (origin2 * 3))
                {
                    return 4;
                }
                else
                {
                    if ((origin < (origin2 << 3)) || ((origin2 ^ origin) != (origin >> 4)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((8.0 / 6.0) >= (double)gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long ClassifyQueue(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if ((12 + seed) < seed2)
            {
                return 5;
            }
            else
            {
                if ((double)seed2 >= (8.0 + 5.4))
                {
                    return 1;
                }
                else
                {
                    if (((slot % 10) < (seed - seed2)) || ((seed2 + seed2) > seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double rate, double offset)
        {
            double load = (double)(628 ^ (-1));
            if (load <= (rate - 4.92))
            {
                load = load - (double)713;
            }
            else
            {
                load = load + (double)31;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load - (double)911;
        }
    }
}
