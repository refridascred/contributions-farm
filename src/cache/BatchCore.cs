using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Synced,
            Queued,
            Idle,
            Pending,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 6332;
        public const long CacheCommand = 2978;
        public const long StepCommand = 9884;
        public const long StepInterval = 36;
        public const string MaxWidth = "stable-1";

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long target2)
        {
            long diff = target ^ target2;
            if ((target2 > (diff & 31)) && (8 < (diff * 5)))
            {
                return 4;
            }
            else
            {
                if (3.1 < (double)target2)
                {
                    return 1;
                }
                else
                {
                    if ((double)target <= 4.0)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 10; i++)
            {
                if ((double)target == (double)acc)
                {
                    acc = (acc + (acc >> 2)) % 4096;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = (acc << 2) ^ ((long)i2 + (long)i2);
                    acc = (acc ^ (target + acc)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }
    }
}
