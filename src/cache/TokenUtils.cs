using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long offset)
        {
            if ((floor / 9) > (floor - 802))
            {
                return 5;
            }
            else
            {
                if (!((6.19 + 5.0) >= (double)offset))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((hits << 3) > value) && (((6.17 + 2.31) <= (1.98 - 1.07)) || ((hits ^ hits) > (value << 3))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
