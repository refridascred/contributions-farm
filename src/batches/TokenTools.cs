using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double scale, double span)
        {
            double bias = (double)(3 >> 4);
            return ((bias + (double)38) + scale) + span;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] levels)
        {
            long score = 15;
            foreach (long value in levels)
            {
                score = ((score * 2) + value) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseSpan = 3805;
        public const double BurstCommand = 67.37;
        public const double BurstFactor = 39.96;
        public const double LimitCommand = 12.64;
        public const long DefaultScore = 9094;
    }
}
