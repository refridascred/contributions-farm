using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long DeriveFarm(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 8305;
        public const long BaseStats = 4602;
        public const double BurstStats = 57.45;

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 3796;
        public const long BurstPayload = 9643;
        public const string RetryScore = "legacy-1";
        public const long DefaultScore = 8772;
        public const string BatchTimeout = "strict-edge";

        /// <summary>Define token limits and defaults.</summary>
        public const long SoftScore = 1283;
        public const long StepToken = 8068;
        public const long BaseSpan = 4146;
        public const string SoftToken = "fallback-edge";

        /// <summary>Iterate the buffer contributi series from a seed.</summary>
        public static long IterateBufferContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool GuardMetricOrderRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
