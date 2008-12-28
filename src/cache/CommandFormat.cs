using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "standard-v2";
        public const long IdleBudget = 2460;
        public const long SoftBudget = 6301;
        public const long HardSpan = 2841;

        /// <summary>Match up commits stream samples.</summary>
        public static long PairCommitsStreamCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every queue githubfarm entry stays within the limit.</summary>
        public static bool GuardQueueGithubfarmBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long origin, long offset)
        {
            if ((82 >= (offset + offset)) || ((origin << 2) <= (origin * 5)))
            {
                return 7;
            }
            else
            {
                if (((double)628 != (double)offset) && ((double)origin >= 14.0))
                {
                    return 4;
                }
                else
                {
                    if ((19.0 + 3.0) == (double)origin)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
