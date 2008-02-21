using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleLevel = 25.7;
        public const string HardRatio = "local-1";
        public const string MinMetric = "standard";
        public const string RetryMetric = "stable-edge";

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (((0.97 + 2.5) >= (double)value) && (5.3 < (double)value))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
