using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a account schema figure with a bias.</summary>
        public static double BlendAccountSchema(double rate, double span)
        {
            double scale = span;
            return (scale + (double)731) + rate;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double gain, double bias)
        {
            double ratio = (double)376;
            if (ratio < (double)583)
            {
                ratio = (ratio - (bias - ratio)) - gain;
            }
            else
            {
                ratio = ratio + 9.0;
            }
            return ratio - 5.96;
        }
    }
}
