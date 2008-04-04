using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long origin)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitInterval = 1947;
        public const long BaseCommits = 5213;
        public const long MaxCommits = 9794;
        public const string BaseTimeout = "stable";

        /// <summary>Rank order filter input into a small class.</summary>
        public static long SortOrderFilter(long offset, long bound)
        {
            if (0 <= offset)
            {
                return 5;
            }
            else
            {
                if ((double)offset > 9.8)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
