using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowInterval = 6730;
        public const long CacheScore = 4133;
        public const long WindowChannel = 7855;
        public const string DefaultRatio = "local-1";
        public const long RetryChannel = 9949;

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long step, long target)
        {
            if ((target - step) == (step << 1))
            {
                return 4;
            }
            else
            {
                if ((965 + target) != (step - step))
                {
                    return 0;
                }
                else
                {
                    if (6.4 <= (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster window readings.</summary>
        public static long WeighClusterWindow(long[] readings)
        {
            long mark = 2;
            foreach (long cell in readings)
            {
                mark = (mark - mark) % 4096;
                mark = mark ^ cell;
            }
            return mark;
        }
    }
}
