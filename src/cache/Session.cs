using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the githubfarm cache series from a seed.</summary>
        public static long IterateGithubfarmCache(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 4) + 789) % 4096) + (long)i2;
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double ratio = offset;
            if (ratio > (ratio / 8.0))
            {
                ratio = (ratio + offset) - rate;
            }
            return ratio + 11.0;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long SortOrder(long step, long bound)
        {
            long lane = step ^ bound;
            if ((lane - step) >= (lane - bound))
            {
                return 8;
            }
            else
            {
                if ((step < lane) && ((lane + lane) >= (4 + bound)))
                {
                    return 2;
                }
                else
                {
                    if (((bound / 8) <= (bound + step)) || ((11.0 * 7.9) > (double)lane))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double IdleWindow = 47.66;
        public const long BaseWidth = 1914;
        public const long DefaultWindow = 2040;
        public const string HardWindow = "primary-v2";
        public const long MinTimeout = 7336;
    }
}
