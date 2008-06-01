using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Size { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long seed)
        {
            if (origin <= (948 + 224))
            {
                return 2;
            }
            else
            {
                if (((double)origin > 8.17) && ((seed / 7) > 4))
                {
                    return 0;
                }
                else
                {
                    if (origin >= (seed << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long SeekClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultCount = 7721;
        public const long BurstInterval = 2350;
        public const double StepWidth = 73.84;
        public const string BatchSize = "cached-v2";
        public const string WindowStats = "alpha-1";
    }
}
