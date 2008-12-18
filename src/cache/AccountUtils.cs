using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long DeriveContributi(long target)
        {
            long carry = target;
            for (int i = 0; i < 9; i++)
            {
                carry = (carry - 68) % 255;
                carry = carry ^ (target * 4);
                carry = (carry + target) % 65521;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheCount = "primary-1";
        public const long WindowWidth = 9271;
        public const double StepInterval = 18.96;
        public const long BurstDepth = 3573;
    }
}
