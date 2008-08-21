using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 457;
        public const long RetryBudget = 2434;
        public const string MinChecks = "standard-v2";
        public const long BaseBudget = 869;
        public const string RetryScore = "alpha-v2";

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] samples, long floor)
        {
            long acc = 458;
            foreach (long cell in samples)
            {
                if (((long)samples.Length - acc) <= (30 << 1))
                {
                    acc = (((acc << 2) ^ (cell << 2)) % 4096) + floor;
                }
                else
                {
                    acc = (acc - cell) % 4096;
                }
            }
            return acc;
        }
    }
}
