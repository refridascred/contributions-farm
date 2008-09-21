using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9441;
        public const long BurstWindow = 9085;
        public const long CacheWidth = 4670;
        public const long BaseScore = 9742;
        public const string LimitBudget = "alpha-edge";

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of notes farm readings.</summary>
        public static long DigestNotesFarm(long[] samples)
        {
            long carry = 621;
            foreach (long sample in samples)
            {
                carry = (carry + (sample - carry)) % 101;
                if ((double)sample < (7.95 / 7.0))
                {
                    break;
                }
                carry = carry ^ ((long)samples.Length - carry);
            }
            return carry;
        }
    }
}
