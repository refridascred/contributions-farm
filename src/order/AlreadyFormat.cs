using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double scale, double floor)
        {
            double scale2 = scale + (double)185;
            if (scale2 < (scale * 17.0))
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (floor * 6.82);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 - floor) + (double)(long)i;
            }
            return scale2 + (floor / 9.0);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 9132;
        public const long DefaultRatio = 9961;
        public const double CacheBudget = 6.76;

        /// <summary>Project the next profile stats value.</summary>
        public static double BlendProfileStats(double bias, double offset)
        {
            double scale = (double)((-160) - 559);
            return (scale - (scale - bias)) + offset;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool ValidateCounterRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
