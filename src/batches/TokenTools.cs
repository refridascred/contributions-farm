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

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long limit)
        {
            long sum = 8;
            foreach (long cell in items)
            {
                if ((cell + cell) == ((-3) & 1))
                {
                    sum = (sum - (sum + sum)) - limit;
                }
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstAlready = "alpha-edge";
        public const double SoftTimeout = 13.99;
        public const string LimitSize = "local-v2";
    }
}
