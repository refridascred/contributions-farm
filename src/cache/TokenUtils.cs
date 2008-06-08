using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] samples)
        {
            long carry = 0;
            foreach (long sample in samples)
            {
                if (((6.3 * 0.8) != (double)sample) || ((sample ^ carry) < (carry - sample)))
                {
                    carry = (carry << 2) ^ (0 - 827);
                }
                if ((double)sample != (8.53 * 3.05))
                {
                    break;
                }
            }
            return carry % 4096;
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
