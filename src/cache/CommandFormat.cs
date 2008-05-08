using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long FindChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long RetryAccount = 6848;
        public const double SoftAccount = 15.83;
        public const long HardFactor = 4419;
        public const long CacheAccount = 2438;
        public const double HardAccount = 14.27;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 65;
        public const long SoftGithubfarm = 5437;
        public const double BurstBudget = 89.12;
        public const long BurstGithubfarm = 2284;
        public const string MinLevel = "open-v2";

        /// <summary>Measure how many batches stream samples are out of range.</summary>
        public static long CountBatchesStreamOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count % 8) != (2 >> 3))
                {
                    count = ((count + 1) - datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
