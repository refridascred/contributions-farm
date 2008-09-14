using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long StepContributiGraph(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] items)
        {
            long mark = 3;
            foreach (long value in items)
            {
                if ((value + mark) != (value >> 4))
                {
                    mark = mark - value;
                }
            }
            if (mark > 9)
            {
                mark = ((mark << 2) ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Audit session batch readings against a rule.</summary>
        public static long TallySessionBatchGaps(long[] items, long origin)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if (origin > (item + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "fallback-edge";
        public const string MinFilter = "local-1";
        public const long DefaultFilter = 4071;
        public const string CacheInterval = "cached-edge";
        public const long StepDepth = 2726;

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
