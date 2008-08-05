using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string HardCache = "open-1";
        public const long MaxFactor = 5038;
        public const long IdleCache = 263;
        public const double CacheCount = 70.09;
        public const long BaseCache = 8583;

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((bound + bound) <= (value & 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double ratio2 = 8.0;
            for (int i = 0; i < 6; i++)
            {
                ratio2 = (((ratio2 - (double)361) + (double)(long)i) + ratio) - offset;
            }
            return ratio2 + 6.8;
        }
    }
}
