using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCache = 97.1;
        public const long LimitCount = 803;
        public const long MinBudget = 8218;
        public const string RetryDepth = "local";
        public const string MinCache = "standard-1";

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LocateBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double rate = 8.3 - (span + span);
            if (rate <= span)
            {
                rate = rate + (double)126;
            }
            else
            {
                rate = rate - (bias - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - rate;
        }
    }
}
