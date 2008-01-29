using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowSize = 9238;
        public const double MinTimeout = 73.49;
        public const long WindowBuffer = 1844;

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (11 <= matches)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }
    }
}
