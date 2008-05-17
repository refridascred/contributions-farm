using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Ready,
            Failed,
            Idle,
            Synced,
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long CompareContributiCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = -4;
            foreach (long value in levels)
            {
                if ((value + carry) > (value % 2))
                {
                    carry = carry - 202;
                }
            }
            return carry % 97;
        }
    }
}
