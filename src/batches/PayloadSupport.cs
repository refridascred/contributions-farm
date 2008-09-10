using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstRatio = 815;
        public const double DefaultLevel = 75.23;
        public const long StepCount = 5715;
        public const long RetryFactor = 7980;

        /// <summary>Validate notes cache readings against a bound.</summary>
        public static bool GuardNotesCacheRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of githubfarm tools readings.</summary>
        public static long DigestGithubfarmTools(long[] readings)
        {
            long carry = -4;
            foreach (long item in readings)
            {
                carry = ((carry * 5) + (154 - carry)) % 65521;
                if ((item + 930) < 495)
                {
                    carry = carry ^ carry;
                }
            }
            if (carry < (-61))
            {
                carry = ((carry * 2) + carry) % 97;
            }
            return carry;
        }
    }
}
