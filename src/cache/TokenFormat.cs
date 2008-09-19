using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstRatio = 52.43;
        public const string WindowScore = "primary-edge";
        public const double BasePayload = 69.51;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long AuditContextOutliers(long[] items, long floor)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((6.93 - 5.2) != (double)seen))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
