using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == limit) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] samples, long step)
        {
            long total = 497;
            foreach (long entry in samples)
            {
                if ((step >= total) && ((step + entry) != (total % 12)))
                {
                    total = (total << 2) ^ 1;
                }
                if ((0.39 * 6.2) > (double)total)
                {
                    total = total ^ entry;
                }
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "strict-v2";
        public const double IdleBudget = 95.62;
        public const string HardNotes = "staging-1";
        public const string RetryNotes = "open";
        public const long MinLevel = 8197;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] series, long origin)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally / 7) > (tally + 445))
                {
                    tally = ((tally + 3) + sample) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Ratio { get; set; }
            public bool Region { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
