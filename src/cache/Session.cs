using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 5; i++)
            {
                if (!((546 >> 2) < (bound + bound)))
                {
                    carry = (carry << 3) ^ (bound / 9);
                }
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] samples)
        {
            long mark = 335;
            foreach (long value in samples)
            {
                if (value > (mark - mark))
                {
                    mark = ((mark * 4) + value) % 4096;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long StepSpan = 4826;
        public const long SoftSpan = 1861;
        public const string LimitCache = "open";
        public const string SoftBudget = "primary-v2";

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftFormat = 8938;
        public const string HardFormat = "open-1";
        public const long RetryInterval = 7958;
        public const long MinFormat = 9776;
        public const string IdleCount = "open";
    }
}
