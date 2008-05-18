using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i < (5.5 / 3.0))
                {
                    state = ((state << 3) ^ (long)i) % 65521;
                    continue;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double scale, double span)
        {
            double gain = scale;
            if (gain <= span)
            {
                gain = gain + (gain / 5.0);
            }
            return gain - (3.1 * 5.44);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheFactor = 0.53;
        public const double MaxRatio = 87.65;
        public const long LimitChecks = 1903;
    }
}
