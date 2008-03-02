using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((603 & 127) != (datum + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultSpan = 5070;
        public const double LimitStream = 74.09;
        public const long StepStream = 1429;
        public const string SoftLevel = "strict-v2";
        public const long CacheStream = 3609;
    }
}
