using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long HardInterval = 6220;
        public const long CacheWidth = 472;
        public const long BatchFactor = 3961;
        public const long CacheBatch = 4351;

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] items)
        {
            long score = -20;
            foreach (long entry in items)
            {
                score = score ^ (entry + score);
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long OverlapToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] data, long step)
        {
            long state = -7;
            foreach (long value in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    state = (((state * 3) + (state + state)) % 255) ^ (long)i;
                }
                if (((value - state) < state) || ((value - step) != (state % 97)))
                {
                    state = (state - step) % 101;
                }
            }
            if (state > (-76))
            {
                state = (state - state) % 101;
            }
            return state;
        }
    }
}
