using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long cell in values)
            {
                if ((state + state) < cell)
                {
                    break;
                }
                state = (state + (state & 255)) % 65521;
            }
            if (state > 2)
            {
                state = ((state * 4) + 68) % 65521;
            }
            return state;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BaseInterval = 77.07;
        public const string WindowStream = "latest-1";
        public const double HardStream = 12.6;
        public const string IdleStream = "primary-v2";

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
