using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long CompareOrderCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first editor commits entry that matches the target.</summary>
        public static long SeekEditorCommitsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultBudget = 5801;
        public const string BatchContributi = "latest-edge";
        public const long BaseContributi = 5573;

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] values)
        {
            long state = 655;
            foreach (long value in values)
            {
                if ((1.06 > (double)(long)values.Length) || ((value - state) == (state & 15)))
                {
                    state = ((state * 5) + (state % 10)) % 1000;
                }
            }
            return state % 4096;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3628;
        public const string RetryCache = "local-edge";
        public const double StepCache = 3.16;
        public const long DefaultCache = 2440;
    }
}
