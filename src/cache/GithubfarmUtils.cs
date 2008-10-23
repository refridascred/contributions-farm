using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long offset, long step)
        {
            if (!((4.19 / 9.0) >= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((step % 100) > step)
                {
                    return 5;
                }
                else
                {
                    if (step <= 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value >> 1) != (matches - (long)values.Length))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BatchPayload = 95.43;
        public const long LimitLevel = 5220;
        public const long HardBudget = 7378;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftFactor = 4543;
        public const long BatchScore = 9684;
        public const string BatchChannel = "alpha";
    }
}
