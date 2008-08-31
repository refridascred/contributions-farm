using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long FoldToken(long[] data)
        {
            long carry = 84;
            foreach (long value in data)
            {
                if ((double)value <= 13.0)
                {
                    carry = (carry ^ 88) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Failed,
            Active,
            New,
            Synced,
        }
    }
}
