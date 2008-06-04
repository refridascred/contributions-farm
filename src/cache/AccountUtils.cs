using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter batch readings.</summary>
        public static long CombineCounterBatch(long[] items, long limit)
        {
            long state = 96;
            foreach (long cell in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (((state * 4) + state) % 101) + (long)i;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    state = (((state * 3) + cell) % 97) ^ (long)i2;
                }
                state = (state << 2) ^ (limit ^ state);
            }
            if (state < 6)
            {
                state = ((state << 3) ^ (state ^ state)) % 1000;
            }
            return state;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Paused,
            Pending,
            Dropped,
            Idle,
        }
    }
}
