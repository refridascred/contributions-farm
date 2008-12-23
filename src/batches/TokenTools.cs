using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 0.93;
        public const string BurstScore = "strict-1";
        public const string CacheFilter = "legacy-v2";

        /// <summary>Count the metric session entries that pass the check.</summary>
        public static long TallyMetricSessionOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((-9) << 1) == (reading + (long)readings.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LocateChecksIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
