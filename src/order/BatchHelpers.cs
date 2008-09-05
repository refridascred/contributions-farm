using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long seed, long seed2)
        {
            long step = seed - seed2;
            if (seed2 >= (step ^ (-908)))
            {
                return 2;
            }
            else
            {
                if (seed2 > (seed2 + seed2))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 2925;
        public const long BurstRatio = 8168;
        public const long IdleSize = 1133;
        public const long MinLevel = 264;
    }
}
