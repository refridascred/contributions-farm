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

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] items)
        {
            long score = 38;
            foreach (long entry in items)
            {
                score = score ^ entry;
                if ((entry << 1) != ((long)items.Length << 1))
                {
                    score = (score ^ (score - 8)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long SoftWidth = 6913;
        public const string RetrySpan = "open";
        public const long DefaultSpan = 9944;
        public const double MinContributi = 12.6;

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
