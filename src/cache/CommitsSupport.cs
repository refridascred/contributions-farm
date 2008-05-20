using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample - sample) > (sample & 15))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long bound)
        {
            long state = 13;
            foreach (long sample in values)
            {
                if (((-82) - state) > (4 << 1))
                {
                    state = (((state << 2) ^ (921 >> 3)) % 255) + sample;
                }
            }
            if (state < 87)
            {
                state = (state ^ (bound - (long)values.Length)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count schema stats pairs that satisfy a relation.</summary>
        public static long PairSchemaStatsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] levels)
        {
            long mix = 0;
            foreach (long datum in levels)
            {
                mix = (((mix << 2) ^ (mix + mix)) % 101) ^ datum;
            }
            return mix;
        }
    }
}
