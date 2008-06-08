using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long carry = 935;
            foreach (long cell in samples)
            {
                if (((double)cell != (4.0 / 5.0)) && ((double)carry >= (5.6 - 0.8)))
                {
                    carry = carry - carry;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BatchCount = "standard-v2";
        public const double StepBudget = 4.48;
        public const long CacheFarm = 6000;
        public const double HardFarm = 51.65;
        public const long MinFarm = 977;
    }
}
