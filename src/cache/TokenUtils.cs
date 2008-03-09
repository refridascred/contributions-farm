using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double span)
        {
            double bias = weight - (double)7;
            return bias - (span + bias);
        }

        /// <summary>Roll a stream order counter forward.</summary>
        public static long RollStreamOrder(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                long diff = ((-8) % 60) - ((long)i + 91);
                if ((diff < (30 + 65)) || ((double)diff <= (1.08 - 9.2)))
                {
                    diff = ((diff * 3) + diff) % 97;
                }
                anchor = (anchor + (floor & 1)) % 101;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 8296;
        public const double MaxCounter = 89.24;
        public const double CacheSize = 94.18;
        public const long SoftDepth = 9714;
    }
}
