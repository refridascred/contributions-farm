using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstWidth = 5846;
        public const string BaseSession = "cached-v2";
        public const string SoftSpan = "strict-v2";
        public const string BurstBudget = "strict-1";

        /// <summary>Locate a already window reading by value.</summary>
        public static long SeekAlreadyWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long seed, long step)
        {
            long cur = seed + step;
            if (step < (seed ^ seed))
            {
                return 7;
            }
            else
            {
                if ((seed <= (step << 1)) && (step >= cur))
                {
                    return 8;
                }
                else
                {
                    if ((double)cur <= (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((cur * 3) > (step ^ step))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }
    }
}
