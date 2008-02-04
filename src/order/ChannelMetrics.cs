using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 19; i++)
            {
                state = (state + state) % 4096;
                if (state >= (long)i)
                {
                    state = state - (state % 60);
                }
                if ((long)i == (target - (long)i))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Locate a githubfarm window reading by value.</summary>
        public static long FindGithubfarmWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxRatio = 9841;
        public const long BurstAlready = 6498;
        public const long BatchAlready = 5160;
        public const double IdleDepth = 70.82;
    }
}
