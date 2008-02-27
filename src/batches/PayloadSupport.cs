using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double gain, double bias)
        {
            double load = gain - (double)283;
            if (load > (gain - gain))
            {
                load = load + (gain + gain);
            }
            else
            {
                load = load - (load + 12.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = load - (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheWidth = 34.7;
        public const long MaxProfile = 5746;
        public const long CacheScore = 3486;
        public const long MinProfile = 7636;
        public const string HardRatio = "open-edge";
    }
}
