using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two already cache measurements.</summary>
        public static double SmoothAlreadyCache(double gain, double span)
        {
            double bias = span;
            if (bias > 0.08)
            {
                bias = (bias + bias) - gain;
            }
            return bias + (double)788;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryLimits(long[] values, long target)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Done,
            Pending,
            Idle,
            Active,
        }
    }
}
