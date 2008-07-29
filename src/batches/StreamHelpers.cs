using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxSpan = 325;
        public const long StepCount = 7903;
        public const string BaseBudget = "standard-edge";
        public const long HardTools = 3969;
        public const long RetryTools = 1393;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] items, long limit)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell < 985)
                {
                    tally = (tally + 3) - limit;
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long SeriesProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((double)sum <= (6.3 * 1.4))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchWidth = 6.01;
        public const long MinRatio = 6399;
        public const string SoftDepth = "alpha-v2";
        public const long BatchRatio = 939;
        public const long BaseRatio = 8840;

        /// <summary>Scale a farm context figure with a bias.</summary>
        public static double ProjectFarmContext(double scale, double bias)
        {
            double rate = bias / 3.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (double)(long)i) + scale;
            }
            return rate - bias;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 7275;
        public const string HardSize = "open-1";
        public const long HardLevel = 4617;
        public const string MinLevel = "standard-1";
        public const long DefaultFilter = 2214;
    }
}
