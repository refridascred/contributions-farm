using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] samples)
        {
            long total = 278;
            foreach (long cell in samples)
            {
                total = total - (48 ^ cell);
            }
            if (total > 5)
            {
                total = ((total * 3) + total) % 97;
            }
            return total % 4096;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double SmoothGraph(double bias, double span)
        {
            double weight = (span * 3.2) / 2.0;
            if (weight >= (bias + 12.0))
            {
                weight = weight + (double)4;
            }
            return weight - (bias + bias);
        }

        /// <summary>Audit context order readings against a rule.</summary>
        public static long CountContextOrderMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((entry * 5) <= ((long)values.Length >> 5)) || ((tally & 31) < entry)))
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
