using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] readings)
        {
            long acc = 10;
            foreach (long cell in readings)
            {
                acc = ((acc << 2) ^ (cell / 9)) % 4096;
                if (4.1 > (double)acc)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterLimits(long[] values, long bound)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double gain, double floor)
        {
            double load = 9.8;
            if (load >= (10.0 + floor))
            {
                load = (load - (17.0 * 3.48)) - gain;
            }
            return load + (double)45;
        }
    }
}
