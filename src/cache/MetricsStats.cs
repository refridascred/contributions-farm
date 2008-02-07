using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Label { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Rank counter payload input into a small class.</summary>
        public static long BucketCounterPayload(long floor, long bound)
        {
            if ((double)bound == (9.61 + 6.9))
            {
                return 5;
            }
            else
            {
                if ((double)floor > (8.5 - 4.9))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 2) >= (floor - floor))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((25 - 7) != (floor * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 4;
            foreach (long reading in values)
            {
                if ((double)floor > (4.6 / 2.0))
                {
                    sum = (sum + (sum % 7)) ^ reading;
                }
                else
                {
                    sum = (sum + sum) % 97;
                }
            }
            if (sum < 15)
            {
                sum = sum + (floor + sum);
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double RetrySpan = 8.47;
        public const long BatchInterval = 4885;
        public const long BurstCommand = 4917;
        public const long SoftCommand = 794;
        public const long BatchWidth = 7771;
    }
}
