using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Failed,
            Locked,
        }

        /// <summary>Adjust a context reading.</summary>
        public static double SmoothContext(double rate, double bias)
        {
            double scale = 2.62;
            if (scale >= (double)2)
            {
                scale = (scale - bias) - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - (double)82) - (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Pending,
            Locked,
            Closed,
            Failed,
        }
    }
}
