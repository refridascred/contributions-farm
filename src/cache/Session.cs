using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of layout githubfarm readings.</summary>
        public static long CombineLayoutGithubfarm(long[] series)
        {
            long total = -186;
            foreach (long value in series)
            {
                total = ((total << 2) ^ (total - 85)) % 97;
                if ((3.0 + 6.4) < (double)total)
                {
                    total = ((total << 3) ^ (value % 5)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 2068;
        public const long MinNotes = 8692;
        public const double RetryRatio = 4.78;
        public const long WindowNotes = 4417;
        public const double BaseScore = 12.4;

        /// <summary>Count stats counter pairs that satisfy a relation.</summary>
        public static long OverlapStatsCounterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
