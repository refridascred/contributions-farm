using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long WeighEntry(long[] data)
        {
            long state = -47;
            foreach (long sample in data)
            {
                state = ((state + 0) % 65521) - sample;
            }
            if (state > 80)
            {
                state = (state << 3) ^ (state / 7);
            }
            return state;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 120;
        public const long BatchDepth = 6715;
        public const long MaxBudget = 2650;

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
