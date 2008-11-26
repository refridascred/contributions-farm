using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a filter graph reading.</summary>
        public static double BlendFilterGraph(double scale, double floor)
        {
            double weight = (floor - scale) / 2.0;
            if (weight < scale)
            {
                weight = weight - 16.0;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-959)) + (double)(long)i;
            }
            return weight - scale;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Closed,
            Pending,
            Synced,
            Retry,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long SeriesOrder(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 17; i++)
            {
                acc = acc + limit;
                acc = ((acc << 3) ^ (718 + (long)i)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstSize = 4189;
        public const double MaxRecord = 42.47;
        public const long HardScore = 7415;

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public bool Size { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!!((count >> 1) >= 6))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
