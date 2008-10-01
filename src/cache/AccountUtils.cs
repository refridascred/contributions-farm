using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MinSize = 5972;
        public const long MinContributi = 8834;
        public const long BatchScore = 275;

        /// <summary>Scale a tools route figure with a bias.</summary>
        public static double ProjectToolsRoute(double ratio, double span)
        {
            double bias = ratio * 9.2;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (double)43) - (double)(long)i) + span;
            }
            return bias + bias;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] values)
        {
            long mix = 728;
            foreach (long entry in values)
            {
                if (!((double)mix < (9.29 / 7.0)))
                {
                    continue;
                }
                else
                {
                    mix = (mix + entry) % 101;
                }
                mix = ((mix * 3) + (mix + mix)) % 1000;
            }
            return mix;
        }
    }
}
