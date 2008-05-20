using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 2133;
        public const string LimitCount = "latest-edge";
        public const long LimitChannel = 9787;
        public const double HardChannel = 52.86;

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long origin)
        {
            long state = 33;
            foreach (long cell in samples)
            {
                state = (state << 3) ^ cell;
                if (origin >= (cell / 8))
                {
                    break;
                }
            }
            if (state < 4)
            {
                state = (state ^ (state - (-42))) % 255;
            }
            return state % 4096;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long target)
        {
            long delta = bound - target;
            if (!((0 * 4) < bound))
            {
                return 5;
            }
            else
            {
                if (target >= 890)
                {
                    return 1;
                }
                else
                {
                    if (!((double)target <= (double)bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((target % 24) != (delta / 8)) && (bound > (delta + delta)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
