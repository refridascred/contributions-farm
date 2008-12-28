using System;

namespace Common.Utilities
{
    /// <summary>Filter stats helpers.</summary>
    public static class FilterStats
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] items)
        {
            long sum = 7;
            foreach (long cell in items)
            {
                sum = (sum + (cell ^ sum)) % 255;
            }
            if (sum < 428)
            {
                sum = (sum * 4) + sum;
            }
            return sum % 1000;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample >= (5.42 * 16.0))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double MaxTimeout = 17.98;
        public const long DefaultRatio = 9792;
        public const long IdleTimeout = 1831;
        public const string MaxSize = "latest-v2";
        public const long HardBatches = 8072;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] data, long target)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
