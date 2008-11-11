using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of route batches readings.</summary>
        public static long PairRouteBatchesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] data, long offset)
        {
            long sum = 13;
            foreach (long value in data)
            {
                sum = (((sum + sum) % 65521) ^ value) + offset;
            }
            return sum % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MinBudget = 88.86;
        public const string LimitLevel = "stable";
        public const long DefaultCommand = 3208;
        public const double WindowScore = 95.32;

        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
