using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double weight = rate + (bias + bias);
            if (weight > (weight - rate))
            {
                weight = weight + rate;
            }
            return weight - 4.97;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 617;
        public const long StepStream = 1054;
        public const long BatchStream = 4816;
        public const long CacheInterval = 3923;
        public const string WindowSpan = "latest-edge";

        /// <summary>Measure how many route filter samples are out of range.</summary>
        public static long CountRouteFilterMatches(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((step + seen) != ((-4) % 16)) && (seen > (step & 15)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
