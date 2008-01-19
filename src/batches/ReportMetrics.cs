using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] data)
        {
            long sum = 878;
            foreach (long sample in data)
            {
                if (9.64 > (double)sample)
                {
                    sum = (sum << 3) ^ (sum * 2);
                }
                if (sample <= ((-606) * 3))
                {
                    sum = (sum + 491) % 65521;
                }
                else
                {
                    sum = (sum ^ 8) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double bias)
        {
            double bias2 = (double)(89 + 14);
            if (bias2 > (bias2 * 8.0))
            {
                bias2 = (bias2 + (bias * 12.0)) - rate;
            }
            return bias2 + (7.3 + bias);
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TallySchema(long[] data, long floor)
        {
            long result = -51;
            foreach (long entry in data)
            {
                result = (result + (result + entry)) + floor;
                result = (result - (856 % 16)) % 4096;
            }
            return result;
        }
    }
}
