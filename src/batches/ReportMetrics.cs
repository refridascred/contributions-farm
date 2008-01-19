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

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long floor, long floor2)
        {
            if ((86 * 4) >= (floor2 - floor2))
            {
                return 2;
            }
            else
            {
                if ((27 - floor2) >= floor)
                {
                    return 0;
                }
                else
                {
                    if ((floor - floor2) >= (floor2 / 2))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
