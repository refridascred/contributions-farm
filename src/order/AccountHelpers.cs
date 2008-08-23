using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of layout entry readings.</summary>
        public static long FoldLayoutEntry(long[] items)
        {
            long score = 862;
            foreach (long sample in items)
            {
                score = ((score + score) % 4096) - sample;
            }
            return score % 4096;
        }

        /// <summary>Count the command filter entries that pass the check.</summary>
        public static long AuditCommandFilterHits(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + sample) <= sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((limit + value) != (value % 24))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Stale,
            Synced,
            Dropped,
            Queued,
            Failed,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowBudget = "alpha-v2";
        public const long HardSession = 8128;
        public const long LimitInterval = 5647;
        public const long BatchSession = 1152;

        /// <summary>Audit contributi session readings against a rule.</summary>
        public static long AuditContributiSessionGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading >= (2.09 + 4.46))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }
    }
}
