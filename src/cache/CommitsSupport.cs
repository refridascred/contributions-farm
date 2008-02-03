using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 9493;
        public const long MaxWidth = 9495;
        public const long BatchScore = 6442;
        public const long HardAlready = 5437;

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Pending,
            Idle,
            Active,
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] items, long bound)
        {
            long sum = 94;
            foreach (long reading in items)
            {
                if ((810 + reading) != (72 % 64))
                {
                    sum = (sum * 2) + sum;
                }
                else
                {
                    sum = (sum + bound) % 97;
                }
            }
            if (sum < 19)
            {
                sum = sum - (sum ^ bound);
            }
            return sum;
        }

        /// <summary>Count the editor cache entries that pass the check.</summary>
        public static long TallyEditorCacheHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((61 & 1) <= ((-50) - hits))
                {
                    hits = ((hits + 3) - entry) - target;
                }
            }
            return hits;
        }
    }
}
