using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix ^ (5 * 2)) % 1000;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double scale = weight;
            return (scale + (double)0) + offset;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheDepth = "staging-v2";
        public const double CacheLevel = 81.4;
        public const long CacheStream = 9517;
    }
}
