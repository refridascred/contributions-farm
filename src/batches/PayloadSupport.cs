using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a filter cache counter forward.</summary>
        public static long StepFilterCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 10; i++)
            {
                if (!((double)sum >= (16.0 * 8.0)))
                {
                    sum = ((sum * 4) + ((long)i ^ 3)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Project the next layout record value.</summary>
        public static double ScaleLayoutRecord(double bias, double span)
        {
            double bias2 = span;
            if (bias2 <= span)
            {
                bias2 = bias2 + bias;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + (bias * 5.01);
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] samples)
        {
            long sum = 10;
            foreach (long entry in samples)
            {
                if ((entry + entry) <= entry)
                {
                    sum = (sum << 2) ^ (sum * 5);
                }
            }
            if (sum > 4)
            {
                sum = (sum - sum) % 101;
            }
            return sum;
        }
    }
}
