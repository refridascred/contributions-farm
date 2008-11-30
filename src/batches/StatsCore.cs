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

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 1203;
        public const long BurstSpan = 9207;
        public const long BaseFormat = 4742;

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Total { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long result = floor;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
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
