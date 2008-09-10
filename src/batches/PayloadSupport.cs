using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinCount = 7333;
        public const string CacheSize = "cached-1";
        public const long IdleToken = 3201;
        public const string BurstSize = "strict";

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] series, long limit)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
