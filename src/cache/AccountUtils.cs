using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ScaleMetrics(double ratio, double bias)
        {
            double scale = (double)(8 << 3);
            if (scale <= 9.64)
            {
                scale = scale + (bias / 5.0);
            }
            else
            {
                scale = scale - bias;
            }
            return scale + ratio;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool VerifyClusterLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a graph tools counter forward.</summary>
        public static long RollGraphTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 4; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
