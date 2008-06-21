using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a entry already reading.</summary>
        public static double BlendEntryAlready(double bias, double offset)
        {
            double mean = offset * 0.9;
            if (mean >= (mean * 5.62))
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - (bias / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (offset - bias)) - (double)(long)i;
            }
            return mean - (bias + bias);
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseBudget = 1592;
        public const long CacheFilter = 703;
        public const long BaseFilter = 9209;
        public const long SoftLevel = 5629;
        public const double MaxFactor = 38.69;
    }
}
