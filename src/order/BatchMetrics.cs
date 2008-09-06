using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Total { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long target, long floor)
        {
            if ((floor >> 1) <= (floor ^ floor))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((9.23 - 0.24) != (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 8560;
        public const double CacheContributi = 76.81;
        public const long RetryContributi = 6837;
        public const long HardCount = 1459;

        /// <summary>Locate a window reading by value.</summary>
        public static long LocateWindowIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BaseScore = "strict-v2";
        public const long RetryRatio = 4231;
        public const long DefaultBudget = 1845;
        public const long MaxInterval = 1050;

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
