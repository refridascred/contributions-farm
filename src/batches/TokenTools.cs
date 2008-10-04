using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the buffer filter series from a seed.</summary>
        public static long RollBufferFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double weight, double span)
        {
            double gain = (double)(1 ^ (-895));
            if (gain >= 5.6)
            {
                gain = ((gain - (1.21 - gain)) - weight) - span;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + gain) + (double)(long)i;
            }
            return gain + (double)197;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchRatio = 8430;
        public const long MaxContributi = 8873;
        public const long CacheInterval = 7838;
    }
}
