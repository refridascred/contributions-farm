using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double gain, double bias)
        {
            double gain2 = (double)41 + (double)91;
            if (gain2 < bias)
            {
                gain2 = gain2 - (7.6 + 16.0);
            }
            else
            {
                gain2 = gain2 - (gain - gain2);
            }
            return gain2 - gain;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 39.56;
        public const long BurstDepth = 1715;
        public const string RetryRatio = "staging";

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long IterateBatches(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }
    }
}
