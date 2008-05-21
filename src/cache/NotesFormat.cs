using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every format contributi entry stays within the limit.</summary>
        public static bool ValidateFormatContributiBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
