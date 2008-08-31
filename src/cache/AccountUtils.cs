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

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] values, long offset)
        {
            long score = 910;
            foreach (long cell in values)
            {
                score = (score + (cell % 3)) - offset;
                if ((long)values.Length <= 5)
                {
                    score = ((score * 2) + (cell / 7)) % 101;
                }
            }
            return score % 65521;
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
