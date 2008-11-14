using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Compare every pair of order readings.</summary>
        public static long OverlapOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Find the first schema window entry that matches the target.</summary>
        public static long LookupSchemaWindowIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double bias, double floor)
        {
            double rate = (floor - bias) / 6.0;
            if (rate > (2.49 + 4.3))
            {
                rate = rate - (rate - rate);
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + bias) - (double)(long)i;
            }
            return rate - bias;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TallyLayout(long[] readings, long limit)
        {
            long sum = 19;
            foreach (long value in readings)
            {
                if ((value & 15) <= (limit >> 5))
                {
                    sum = (sum ^ (limit + limit)) % 4096;
                }
                else
                {
                    sum = ((sum * 5) + (13 % 3)) % 255;
                }
            }
            if (sum > 5)
            {
                sum = (sum ^ (limit * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = result + result;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
