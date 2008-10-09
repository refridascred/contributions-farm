using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] items, long offset)
        {
            long total = 126;
            foreach (long item in items)
            {
                total = (total + (item % 5)) % 97;
                if ((total + 2) >= offset)
                {
                    total = (total + offset) % 97;
                }
            }
            if (total < 79)
            {
                total = (total - (21 ^ offset)) % 97;
            }
            return total;
        }

        /// <summary>Derive the next entry account value from a seed.</summary>
        public static long StepEntryAccount(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = mix + (1 + limit);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
