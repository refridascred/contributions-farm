using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "staging-edge";
        public const long MaxSpan = 7433;
        public const long SoftTools = 1639;
        public const long DefaultSize = 3229;
        public const string CacheTimeout = "legacy-edge";

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] readings)
        {
            long sum = 901;
            foreach (long sample in readings)
            {
                if (((double)sum <= (15.0 + 4.5)) && ((double)sum >= (double)7))
                {
                    sum = ((sum - 0) % 255) ^ sample;
                }
                if ((2.0 * 2.4) < (double)sum)
                {
                    sum = (sum << 3) ^ 32;
                }
            }
            if (sum > 831)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double rate = floor;
            if (rate <= (double)613)
            {
                rate = rate - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (rate * 0.32)) + (double)(long)i;
            }
            return rate + (scale + scale);
        }
    }
}
