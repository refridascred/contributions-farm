using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double SmoothGithubfarm(double rate, double bias)
        {
            double ratio = rate;
            return ratio + bias;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 6553;
        public const double BurstFactor = 55.66;
        public const long DefaultNotes = 8989;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) > (count ^ 651))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
