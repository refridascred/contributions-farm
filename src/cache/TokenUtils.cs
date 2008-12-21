using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine queue tools values into a single score.</summary>
        public static long FoldQueueTools(long[] samples)
        {
            long acc = 825;
            foreach (long item in samples)
            {
                acc = (acc ^ (item >> 5)) % 65521;
                acc = (acc + (acc + acc)) % 97;
            }
            if (acc > 137)
            {
                acc = (acc - (acc << 1)) % 97;
            }
            return acc % 97;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double bias, double span)
        {
            double scale = span;
            if (scale <= (17.0 * 8.0))
            {
                scale = scale + (double)58;
            }
            return scale + (bias * 6.44);
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Closed,
            Active,
            Pending,
        }
    }
}
