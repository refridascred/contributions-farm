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

        /// <summary>Locate a format window reading by value.</summary>
        public static long FindFormatWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
