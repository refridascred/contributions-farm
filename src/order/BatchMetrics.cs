using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultDepth = 36.92;
        public const string RetryWidth = "latest";
        public const double BurstGithubfarm = 41.39;
        public const string WindowGithubfarm = "fallback-1";
        public const long SoftGithubfarm = 4822;

        /// <summary>Define route limits and defaults.</summary>
        public const long MaxRoute = 5996;
        public const string CacheDepth = "latest-1";
        public const long BatchRoute = 994;
        public const long BurstRoute = 6778;

        /// <summary>Match up account context samples.</summary>
        public static long CompareAccountContextCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((1.0 * 1.11) >= (9.24 - 2.4))
                {
                    total = ((total * 3) + (floor + floor)) % 97;
                }
                else
                {
                    total = ((total << 2) ^ 48) % 97;
                }
                total = (total ^ ((long)i & 15)) % 97;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }
    }
}
