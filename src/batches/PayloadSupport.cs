using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const string SoftSpan = "staging-edge";
        public const long DefaultBudget = 6773;
        public const double CacheCommand = 4.5;
        public const double DefaultSize = 30.19;
        public const long WindowCommand = 6722;

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LocateMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (((entry % 8) < (-375)) || (((48 + entry) > (entry >> 4)) && ((double)entry == (5.0 + 5.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
