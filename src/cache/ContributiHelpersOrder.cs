using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double rate, double offset)
        {
            double scale = (double)4 + (18.0 - offset);
            if (scale < 4.59)
            {
                scale = (scale - (double)8) - rate;
            }
            return scale - (scale * 16.0);
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Active,
            Retry,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long SortGithubfarm(long seed, long step)
        {
            if ((step / 3) >= (seed >> 1))
            {
                return 7;
            }
            else
            {
                if ((step + seed) <= (37 * 4))
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
