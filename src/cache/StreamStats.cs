using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Failed,
            Ready,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((double)count <= 4.0))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Project the next githubfarm schema value.</summary>
        public static double SmoothGithubfarmSchema(double bias, double span)
        {
            double scale = (9.03 * 14.0) * 18.0;
            if (scale > span)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - (double)796;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long bound)
        {
            if ((double)seed == (1.1 + 9.03))
            {
                return 5;
            }
            else
            {
                if (((bound * 4) < seed) || ((97 * 4) == (bound + seed)))
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
}
