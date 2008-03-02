using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Rank { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long offset, long bound)
        {
            long diff = offset + bound;
            if ((diff * 3) <= (diff + offset))
            {
                return 3;
            }
            else
            {
                if (((double)bound > (7.4 * 7.0)) && (bound <= (bound + diff)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double floor)
        {
            double mean = (double)(3 - 89);
            if (mean <= (13.0 + 3.0))
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (5.42 + floor)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long RollAlready(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    result = ((result << 3) ^ (result / 2)) ^ (long)i2;
                    result = result - (result >> 2);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
