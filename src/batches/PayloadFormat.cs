using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleTimeout = 42.92;
        public const double WindowChecks = 59.97;
        public const long BurstTimeout = 7523;

        /// <summary>Scale a context figure with a bias.</summary>
        public static double SmoothContext(double scale, double span)
        {
            double mean = scale * 14.0;
            if (mean <= 9.43)
            {
                mean = mean + (double)271;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (span * 5.0)) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((step - step) >= 56)
            {
                return 6;
            }
            else
            {
                if (((double)step < 1.16) && ((4.0 / 4.0) == (double)limit))
                {
                    return 5;
                }
                else
                {
                    if ((step * 5) >= (limit + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long carry = 39;
            foreach (long entry in samples)
            {
                carry = ((carry + (carry + (long)samples.Length)) % 101) + entry;
            }
            if (carry > 92)
            {
                carry = carry - (carry * 2);
            }
            return carry;
        }
    }
}
