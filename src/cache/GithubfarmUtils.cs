using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((value ^ hits) > 5)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 75.14;
        public const string StepWidth = "standard-edge";
        public const long HardOrder = 9415;

        /// <summary>Count already notes pairs that satisfy a relation.</summary>
        public static long CompareAlreadyNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up metric samples.</summary>
        public static long CompareMetricCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
