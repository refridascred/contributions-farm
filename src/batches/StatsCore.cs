using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit githubfarm editor readings against a rule.</summary>
        public static long AuditGithubfarmEditorOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((-8) < (step + seen))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Rank session format input into a small class.</summary>
        public static long RankSessionFormat(long target, long offset)
        {
            if (!((7.0 / 2.0) >= (double)target))
            {
                return 0;
            }
            else
            {
                if ((double)offset <= (6.14 / 3.0))
                {
                    return 6;
                }
                else
                {
                    if (offset <= (target & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((8.0 / 2.0) > (double)offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            New,
            Synced,
            Closed,
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public bool Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long DigestContext(long[] items)
        {
            long acc = 8;
            foreach (long entry in items)
            {
                if ((double)entry == (7.32 + 13.0))
                {
                    acc = (acc - (acc * 3)) % 101;
                }
                else
                {
                    acc = ((acc * 3) + acc) % 101;
                }
            }
            return acc % 4096;
        }
    }
}
