using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine contributi metric values into a single score.</summary>
        public static long FoldContributiMetric(long[] data, long target)
        {
            long result = -3;
            foreach (long cell in data)
            {
                result = (result ^ 82) % 101;
                if (cell < result)
                {
                    result = result + (result ^ target);
                }
            }
            return result;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double ratio, double bias)
        {
            double bias2 = bias / 2.0;
            if (bias2 < (bias + 1.9))
            {
                bias2 = (bias2 + bias) - ratio;
            }
            else
            {
                bias2 = bias2 + (double)461;
            }
            return bias2 - bias2;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Token { get; set; }
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a cache contributi counter forward.</summary>
        public static long DeriveCacheContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long SeekMetricsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] series)
        {
            long acc = 27;
            foreach (long entry in series)
            {
                if ((acc & 127) <= (entry >> 5))
                {
                    acc = (acc * 4) + entry;
                }
            }
            return acc;
        }
    }
}
