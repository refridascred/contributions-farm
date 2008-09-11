using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the commits context series from a seed.</summary>
        public static long DeriveCommitsContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                result = (result ^ ((long)i / 4)) % 1000;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Blend two window buffer measurements.</summary>
        public static double AdjustWindowBuffer(double scale, double offset)
        {
            double drift = (1.0 - scale) * 6.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (4.8 - offset)) - (double)(long)i;
            }
            return drift + (scale + offset);
        }
    }
}
