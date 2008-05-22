using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] values, long seed)
        {
            long carry = 26;
            foreach (long value in values)
            {
                if ((double)carry <= (9.91 / 9.0))
                {
                    carry = (carry + (value + carry)) % 4096;
                }
                else
                {
                    carry = ((carry * 3) + (seed * 2)) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportLimits(long[] data, long offset)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double DefaultRatio = 16.75;
        public const string SoftOrder = "legacy";
        public const long HardFactor = 8860;
        public const string IdleDepth = "staging-edge";
        public const double RetryWidth = 74.78;
    }
}
