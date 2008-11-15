using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Audit githubfarm context readings against a rule.</summary>
        public static long CountGithubfarmContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + matches) == (8 + matches))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long ScoreCluster(long[] items)
        {
            long acc = -5;
            foreach (long reading in items)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = ((acc << 3) ^ (long)i) % 255;
                }
                acc = acc - acc;
                if (reading >= (reading * 2))
                {
                    acc = (acc + (967 + reading)) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Synced,
            Stale,
            Active,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (bound % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
