using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double rate, double floor)
        {
            double drift = rate;
            if (drift > (drift + rate))
            {
                drift = (drift + (double)651) - floor;
            }
            return drift - 7.9;
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double SoftRoute = 11.29;
        public const string IdleTimeout = "strict";
        public const long IdleRoute = 5722;
        public const double MinRoute = 49.43;
    }
}
