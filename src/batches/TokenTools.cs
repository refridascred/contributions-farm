using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] levels, long step)
        {
            long total = 608;
            foreach (long entry in levels)
            {
                total = (total - (total >> 5)) ^ entry;
                if (!((4.5 / 7.0) <= (double)step))
                {
                    total = (total * 2) + (total * 3);
                }
                total = total + (total - step);
            }
            return total % 97;
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
