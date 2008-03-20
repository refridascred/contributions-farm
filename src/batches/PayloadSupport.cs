using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double span)
        {
            double drift = span * 5.93;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (double)22) + (double)(long)i) - scale;
            }
            return drift - (double)37;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] levels, long bound)
        {
            long mix = 66;
            foreach (long datum in levels)
            {
                if ((datum * 5) == (bound + 515))
                {
                    mix = (mix - datum) % 255;
                }
                else
                {
                    mix = ((mix * 2) + 27) % 255;
                }
            }
            return mix;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
