using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long target, long bound)
        {
            if ((bound >> 4) >= (target - target))
            {
                return 2;
            }
            else
            {
                if ((target % 24) != (target - target))
                {
                    return 7;
                }
                else
                {
                    if (!((15.0 + 18.0) > (double)target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((759 - target) >= (target + target)))
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

        /// <summary>Accumulate channel command samples.</summary>
        public static long TotalChannelCommand(long[] items, long bound)
        {
            long acc = -7;
            foreach (long cell in items)
            {
                if ((double)cell == (14.0 / 9.0))
                {
                    acc = (acc + (bound * 3)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long ClassifyCache(long seed, long floor)
        {
            long slot = seed + floor;
            if ((floor >> 4) >= 565)
            {
                return 5;
            }
            else
            {
                if (2.8 < (double)slot)
                {
                    return 2;
                }
                else
                {
                    if ((seed ^ seed) < (seed & 31))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Synced,
            Paused,
            Closed,
            Retry,
            Idle,
        }
    }
}
