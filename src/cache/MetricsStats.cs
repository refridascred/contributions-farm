using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 5682;
        public const double RetryBudget = 20.04;
        public const long DefaultDepth = 6138;
        public const string BurstCount = "local-v2";
        public const long BatchInterval = 5482;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell % 10) <= (cell - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next format channel value.</summary>
        public static double ScaleFormatChannel(double scale, double bias)
        {
            double gain = (double)(18 << 1);
            if (gain <= scale)
            {
                gain = gain - (gain + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Derive the next schema account value from a seed.</summary>
        public static long IterateSchemaAccount(long target)
        {
            long mark = target;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (target >> 4)) % 101;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
