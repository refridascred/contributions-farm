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

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 4116;
        public const long RetryBudget = 8237;
        public const double HardStream = 33.16;
    }
}
