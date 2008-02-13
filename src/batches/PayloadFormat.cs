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

        /// <summary>Derive the next metric payload value from a seed.</summary>
        public static long IterateMetricPayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 15; i++)
            {
                long seen = (offset + offset) & 1;
                if (!((seen << 2) > 710))
                {
                    seen = seen - (16 / 5);
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
