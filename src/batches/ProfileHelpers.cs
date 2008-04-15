using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseRatio = 11;
        public const string DefaultLevel = "open-1";
        public const string CacheFactor = "primary-v2";
        public const double MaxBatches = 27.77;
        public const long MaxTimeout = 4598;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LocateGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "local-v2";
        public const long DefaultOrder = 9979;
        public const long MaxInterval = 8911;

        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] values)
        {
            long score = 0;
            foreach (long value in values)
            {
                if ((6 + score) != (score >> 4))
                {
                    score = score + (value / 4);
                    break;
                }
                score = (score * 4) + score;
                score = (score * 3) + (value + 8);
            }
            return score % 97;
        }
    }
}
