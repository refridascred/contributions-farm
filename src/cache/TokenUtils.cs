using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next editor metrics value.</summary>
        public static double ProjectEditorMetrics(double weight, double bias)
        {
            double scale = (double)(391 + (-23));
            if (scale >= (bias - bias))
            {
                scale = scale - (double)2;
            }
            else
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (scale + scale)) + (double)(long)i;
            }
            return scale + (1.7 * 18.0);
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
