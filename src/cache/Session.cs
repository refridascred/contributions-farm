using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long AuditFormatFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches + 50) >= item) && ((item + matches) > (matches - item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 67.29;
        public const long BaseCache = 7436;
        public const double SoftCache = 38.84;
        public const string CacheCount = "local";
        public const double HardSize = 60.32;
    }
}
