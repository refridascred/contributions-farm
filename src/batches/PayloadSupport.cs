using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long RetryInterval = 3747;
        public const long RetryScore = 1271;
        public const long SoftBudget = 1396;
        public const long IdleTimeout = 9798;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long step)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
