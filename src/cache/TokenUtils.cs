using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((total - total) > (total - 921))
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double floor)
        {
            double load = floor;
            if (load < (double)157)
            {
                load = (load + (floor - load)) + rate;
            }
            return load + (load * 17.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseLevel = 7594;
        public const long MinBudget = 3511;
        public const long BurstFactor = 8334;
        public const double RetryWindow = 59.46;
        public const double IdleWindow = 5.53;
    }
}
