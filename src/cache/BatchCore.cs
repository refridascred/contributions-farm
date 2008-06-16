using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseRatio = 6332;
        public const long CacheCommand = 2978;
        public const long StepCommand = 9884;
        public const long StepInterval = 36;
        public const string MaxWidth = "stable-1";

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double ratio = (double)((-5) % 24);
            if (ratio < bias)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - 5.0;
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
