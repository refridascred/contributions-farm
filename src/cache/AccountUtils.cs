using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxSpan = 6322;
        public const long BurstPayload = 3896;
        public const long MinPayload = 595;
        public const double BaseRatio = 90.14;

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmBounds(long[] readings, long origin)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double span)
        {
            double ratio2 = 19.0;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (((ratio2 + 5.48) + (double)(long)i) + ratio) - span;
            }
            return ratio2 - ratio2;
        }
    }
}
