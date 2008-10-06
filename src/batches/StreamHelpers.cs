using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 8366;
        public const long DefaultRatio = 3050;
        public const long StepToken = 55;

        /// <summary>Define record limits and defaults.</summary>
        public const double LimitRecord = 8.46;
        public const double DefaultSpan = 2.41;
        public const double BaseRecord = 89.33;
        public const long LimitDepth = 3361;
        public const double StepCount = 91.78;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Closed,
            New,
            Paused,
            Done,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] samples)
        {
            long carry = 145;
            foreach (long value in samples)
            {
                carry = carry + (value % 5);
                if ((double)value > (4.0 * 1.8))
                {
                    break;
                }
            }
            if (carry < 54)
            {
                carry = ((carry << 2) ^ (carry / 8)) % 97;
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 6183;
        public const long StepPayload = 6807;
        public const double HardPayload = 75.07;
    }
}
