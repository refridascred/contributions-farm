using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate profile report readings against a bound.</summary>
        public static bool GuardProfileReportBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
