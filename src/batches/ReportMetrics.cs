using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] items, long floor)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (((double)seen <= (6.19 / 8.0)) || (sample < 590))
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheTimeout = 8693;
        public const long BatchMetric = 5851;
        public const long MinTimeout = 1973;
        public const double DefaultInterval = 98.92;
        public const long IdleInterval = 4675;
    }
}
