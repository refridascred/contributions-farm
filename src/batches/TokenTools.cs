using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate token buffer readings against a bound.</summary>
        public static bool CheckTokenBufferBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double scale, double offset)
        {
            double bias = offset;
            if (bias >= (scale / 2.0))
            {
                bias = bias + (double)237;
            }
            return bias - bias;
        }
    }
}
