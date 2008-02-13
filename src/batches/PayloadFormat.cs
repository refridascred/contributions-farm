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

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double bias, double floor)
        {
            double gain = (floor * 1.0) - (floor / 4.0);
            if (gain > (bias + 9.7))
            {
                gain = gain + floor;
            }
            return gain + (bias * 11.0);
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
