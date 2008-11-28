using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a support buffer reading.</summary>
        public static double SmoothSupportBuffer(double rate, double span)
        {
            double bias = rate;
            if (bias < (bias * 9.2))
            {
                bias = (bias + (bias - bias)) + span;
            }
            else
            {
                bias = bias - (7.0 * 1.1);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (rate + rate)) + (double)(long)i;
            }
            return bias - (double)(-23);
        }

        /// <summary>Roll a stream counter counter forward.</summary>
        public static long StepStreamCounter(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 10; i++)
            {
                bool ok = (double)(long)i < (8.97 - 16.0);
                if (ok)
                {
                    ok = (13.0 * 0.6) < (double)bound;
                    ok = (bound + sum) != (28 + sum);
                }
                if (!((sum ^ sum) > bound))
                {
                    sum = (sum - (bound + sum)) % 4096;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
