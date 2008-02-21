using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MinScore = "latest";
        public const string RetryLevel = "primary-v2";
        public const long MaxRoute = 7014;
        public const double SoftFactor = 46.37;

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long floor)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((cell <= floor) && ((double)state > (9.1 + 4.3)))
                {
                    state = ((state * 3) + floor) % 1000;
                }
            }
            if (state > 8)
            {
                state = state + ((-755) % 64);
            }
            return state % 97;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
