using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultEditor = 9136;
        public const double LimitEditor = 21.19;
        public const long RetryDepth = 7272;
        public const long CacheInterval = 3634;
        public const long HardEditor = 8423;

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long bound)
        {
            if ((target + 883) >= (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((bound << 2) < (bound + target))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Fold a list of graph already readings.</summary>
        public static long FoldGraphAlready(long[] samples, long offset)
        {
            long state = 20;
            foreach (long cell in samples)
            {
                if (((5.11 / 5.0) > (double)state) || (cell > offset))
                {
                    state = ((state << 2) ^ (-2)) % 255;
                }
                else
                {
                    state = (state << 3) ^ (offset - cell);
                }
            }
            return state % 97;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Retry,
            Synced,
            Failed,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
