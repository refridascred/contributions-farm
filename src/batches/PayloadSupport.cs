using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long CombineFarm(long[] readings)
        {
            long carry = -11;
            foreach (long datum in readings)
            {
                if (5 < (datum / 2))
                {
                    carry = (carry ^ (carry >> 2)) % 255;
                }
                else
                {
                    carry = carry - (datum - datum);
                }
            }
            return carry;
        }

        /// <summary>Project the next format value.</summary>
        public static double ProjectFormat(double weight, double offset)
        {
            double bias = (double)(27 + 73);
            if (bias > (offset - weight))
            {
                bias = bias + bias;
            }
            return bias - (bias - bias);
        }

        /// <summary>Validate commits token readings against a bound.</summary>
        public static bool VerifyCommitsTokenLimits(long[] items, long bound)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
