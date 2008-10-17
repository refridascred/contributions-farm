using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next account value.</summary>
        public static double AdjustAccount(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 > bias3)
            {
                bias3 = bias3 - bias2;
            }
            return bias3 + (bias / 8.0);
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long seed)
        {
            long total = seed;
            for (int i = 0; i < 18; i++)
            {
                if (seed > ((long)i >> 5))
                {
                    total = (total << 2) ^ total;
                    total = (total + (long)i) % 101;
                }
                total = ((total << 2) ^ (8 ^ total)) % 255;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
