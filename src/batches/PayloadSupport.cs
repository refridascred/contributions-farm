using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double weight, double bias)
        {
            double gain = (double)(43 + (-9));
            if (gain > (double)9)
            {
                gain = (gain - (gain - bias)) + weight;
            }
            return gain + bias;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] items)
        {
            long sum = 3;
            foreach (long cell in items)
            {
                if ((7.0 * 2.11) >= (double)cell)
                {
                    sum = ((sum << 3) ^ cell) % 1000;
                }
                else
                {
                    sum = sum ^ cell;
                }
                if (cell < (472 ^ 1))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Limit { get; set; } = "";
            public bool Ratio { get; set; }
            public double Count { get; set; }
        }
    }
}
