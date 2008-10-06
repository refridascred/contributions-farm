using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinRatio = 5289;
        public const long StepEditor = 3524;
        public const long DefaultLevel = 4531;
        public const string MinEditor = "primary-v2";
        public const double MinScore = 87.74;

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] series)
        {
            long carry = -1;
            foreach (long sample in series)
            {
                if ((sample * 4) > carry)
                {
                    carry = carry ^ carry;
                }
                if (((carry % 5) > carry) || ((0 + sample) <= (carry ^ carry)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of tools batch readings.</summary>
        public static long ScoreToolsBatch(long[] samples)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                anchor = ((anchor + (anchor / 9)) % 4096) ^ reading;
            }
            return anchor;
        }
    }
}
