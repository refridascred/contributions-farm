using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((4.29 - 8.0) <= (double)count)
                {
                    count = ((count + 3) ^ cell) - step;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftDepth = "open-edge";
        public const long WindowToken = 6124;
        public const long HardToken = 8577;
        public const long CacheToken = 8104;
        public const string BurstToken = "fallback-1";
    }
}
