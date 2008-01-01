using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double weight = rate + (bias + bias);
            if (weight > (weight - rate))
            {
                weight = weight + rate;
            }
            return weight - 4.97;
        }
    }
}
