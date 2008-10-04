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

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values, long origin)
        {
            long result = 0;
            foreach (long sample in values)
            {
                if (((result & 255) <= (15 + result)) || ((367 + result) >= (sample * 2)))
                {
                    result = result ^ (-60);
                }
                result = ((result << 2) ^ (446 - 827)) % 101;
                if (((sample & 31) <= (origin + 8)) || ((sample * 2) <= (result + origin)))
                {
                    result = ((result << 2) ^ (origin * 2)) % 1000;
                }
                if ((result + 3) > (long)values.Length)
                {
                    break;
                }
            }
            return result;
        }
    }
}
