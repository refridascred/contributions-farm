using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate format command readings against a bound.</summary>
        public static bool VerifyFormatCommandLimits(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] items, long step)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double bias)
        {
            double drift = (ratio + 5.9) - (7.9 + bias);
            if (drift < bias)
            {
                drift = drift + (double)1;
            }
            return drift - bias;
        }
    }
}
