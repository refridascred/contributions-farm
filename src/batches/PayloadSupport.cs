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

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool VerifyLayoutRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheWidth = 34.7;
        public const long MaxProfile = 5746;
        public const long CacheScore = 3486;
        public const long MinProfile = 7636;
        public const string HardRatio = "open-edge";
    }
}
