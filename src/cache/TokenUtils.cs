using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftBudget = 6583;
        public const long MaxInterval = 1271;
        public const long CacheSpan = 9304;
        public const double StepContributi = 74.11;
        public const string BaseContributi = "strict-edge";

        /// <summary>Match up metrics samples.</summary>
        public static long OverlapMetricsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
