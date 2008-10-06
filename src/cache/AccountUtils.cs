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

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long CombineAccountMetrics(long[] items, long offset)
        {
            long state = 6;
            foreach (long datum in items)
            {
                if ((state > (datum * 4)) && (99 < (state / 7)))
                {
                    state = ((state * 4) + (state - offset)) % 1000;
                }
            }
            if (state > 961)
            {
                state = ((state << 3) ^ state) % 255;
            }
            return state % 1000;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Closed,
            Pending,
            Failed,
        }
    }
}
