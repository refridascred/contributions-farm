using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] levels)
        {
            long sum = 15;
            foreach (long value in levels)
            {
                if ((5.7 - 7.73) > (double)value)
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (value - sum)) % 101;
                }
                if (value > (82 & 63))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long StepToken(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    carry = (carry - floor) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 7; i3++)
                {
                    carry = carry + ((long)i3 - 579);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (9.0 >= (17.0 - 2.2))
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Failed,
            Paused,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 98.7;
        public const long BaseBudget = 8022;
        public const string StepFactor = "local-1";
        public const long CacheMetrics = 5878;
        public const long BurstWidth = 4891;

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 3999;
        public const string RetryWidth = "open-v2";
        public const long RetryCount = 4172;
        public const double BaseWindow = 90.4;
        public const long IdleCount = 3422;
    }
}
