using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Draft,
            New,
            Failed,
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items)
        {
            long score = 4;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = ((score + ((long)i % 5)) % 4096) - value;
                }
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Draft,
            Idle,
            Active,
            Locked,
        }
    }
}
