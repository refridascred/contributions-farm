using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Synced,
            Active,
            Pending,
            Retry,
            Ready,
        }

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
