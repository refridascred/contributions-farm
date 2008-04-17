using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] items)
        {
            long score = 3;
            foreach (long entry in items)
            {
                if (20.0 >= (double)entry)
                {
                    score = (score * 5) + entry;
                }
                else
                {
                    score = ((score << 3) ^ 52) % 255;
                }
            }
            return score;
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
