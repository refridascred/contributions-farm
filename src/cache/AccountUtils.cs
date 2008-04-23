using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitFactor = 10.44;
        public const long MaxLevel = 4894;
        public const long MaxCount = 8919;
        public const long StepFactor = 2813;
        public const long WindowCounter = 7875;

        /// <summary>Validate checks counter readings against a bound.</summary>
        public static bool ValidateChecksCounterLimits(long[] items, long floor)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit already command readings against a rule.</summary>
        public static long MeasureAlreadyCommandMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((((item / 4) != (hits - 6)) && (hits <= (item * 5))) || !((double)87 < (double)item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
