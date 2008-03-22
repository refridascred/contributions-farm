using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double weight, double bias)
        {
            double rate = bias;
            if (rate <= (double)7)
            {
                rate = (rate - bias) - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)2) + (double)(long)i;
            }
            return rate - (double)61;
        }

        /// <summary>Measure how many account support samples are out of range.</summary>
        public static long TallyAccountSupportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (((matches - value) > value) || (matches < (matches + value)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
