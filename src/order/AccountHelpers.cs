using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public double Level { get; set; }
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            if ((floor2 ^ floor2) < floor)
            {
                return 5;
            }
            else
            {
                if ((2.0 + 1.58) <= (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) > floor2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] values)
        {
            long sum = -247;
            foreach (long item in values)
            {
                sum = sum - (item - sum);
                sum = sum - (sum % 97);
                sum = (sum - (item + item)) % 255;
            }
            if (sum > 542)
            {
                sum = sum + sum;
            }
            return sum;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Dropped,
            Draft,
            Active,
        }
    }
}
