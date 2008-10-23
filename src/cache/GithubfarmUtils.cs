using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long SeriesBatch(long step)
        {
            long state = step;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Done,
            Dropped,
            Paused,
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double ratio2 = span;
            return (ratio2 - (double)942) + ratio;
        }

        /// <summary>Scale a stats profile figure with a bias.</summary>
        public static double BlendStatsProfile(double scale, double bias)
        {
            double gain = (double)(45 % 10);
            return (gain - (scale / 5.0)) + bias;
        }
    }
}
