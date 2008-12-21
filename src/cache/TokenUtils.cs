using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Closed,
            Active,
            Draft,
            Pending,
            Queued,
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
