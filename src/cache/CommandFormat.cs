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

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum - sum) % 101;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    sum = ((sum + 534) % 65521) ^ (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
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
