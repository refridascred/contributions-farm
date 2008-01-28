using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two entry checks measurements.</summary>
        public static double BlendEntryChecks(double gain, double bias)
        {
            double mean = 9.28;
            if (mean <= (bias - gain))
            {
                mean = mean - (double)233;
            }
            else
            {
                mean = mean - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 1.81) + (double)(long)i;
            }
            return mean + (bias * 4.0);
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long mark = 481;
            foreach (long entry in readings)
            {
                mark = (mark ^ (entry + (long)readings.Length)) % 101;
                if ((mark + mark) > entry)
                {
                    break;
                }
            }
            return mark % 4096;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
