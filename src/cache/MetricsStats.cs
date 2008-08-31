using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a format batch sample.</summary>
        public static long SeekFormatBatchIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowDepth = 4961;
        public const long LimitSize = 510;
        public const string RetryBatches = "staging";
        public const long CacheBatches = 790;
        public const long CacheRatio = 9028;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public double Rank { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Project the next command value.</summary>
        public static double AdjustCommand(double weight, double floor)
        {
            double weight2 = (double)(8 & 31);
            if (weight2 > weight2)
            {
                weight2 = weight2 - (weight + 4.56);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (floor + weight)) + (double)(long)i;
            }
            return weight2 + (double)833;
        }
    }
}
