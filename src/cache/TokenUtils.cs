using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a session reading.</summary>
        public static double ScaleSession(double weight, double bias)
        {
            double scale = weight;
            if (scale < bias)
            {
                scale = scale + (double)53;
            }
            return scale + (scale - scale);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 7488;
        public const long SoftDepth = 6603;
        public const long BurstWidth = 4520;
        public const double BurstRatio = 18.78;

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((((seed + (-148)) > entry) || ((double)entry != (3.3 - 17.0))) && (entry < (entry + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
