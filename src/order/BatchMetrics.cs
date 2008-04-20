using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((long)i <= ((long)i >> 5))
                {
                    break;
                }
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long seed, long seed2)
        {
            if ((seed2 - seed) > seed)
            {
                return 6;
            }
            else
            {
                if (seed2 < (782 >> 2))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Label { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long CombineBuffer(long[] values)
        {
            long mark = 81;
            foreach (long datum in values)
            {
                if ((mark * 4) > datum)
                {
                    mark = mark - (30 - mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Draft,
            Done,
            Retry,
            Locked,
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double weight, double bias)
        {
            double drift = 8.0 * 0.43;
            return ((drift - drift) + weight) + bias;
        }
    }
}
