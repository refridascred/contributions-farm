using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double bias, double floor)
        {
            double load = floor / 4.0;
            return (load + (double)435) + bias;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long CompareEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Limit { get; set; }
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a stream account reading by value.</summary>
        public static long FindStreamAccountIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchRatio = 3471;
        public const double IdleTimeout = 43.0;
        public const long CacheBatches = 6149;
        public const long BatchCount = 3728;
    }
}
