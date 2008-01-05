using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of notes already readings.</summary>
        public static long TallyNotesAlready(long[] values)
        {
            long total = 1;
            foreach (long sample in values)
            {
                if ((double)total <= 17.0)
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = (total - (sample ^ 2)) % 255;
                }
            }
            return total;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long seed)
        {
            if (((double)seed >= (4.5 * 0.02)) && ((seed - seed) >= seed))
            {
                return 8;
            }
            else
            {
                if ((3.9 - 4.0) >= (double)step)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Closed,
            Paused,
            Active,
            Draft,
        }

        /// <summary>Audit metric editor readings against a rule.</summary>
        public static long TallyMetricEditorGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((seed + seen) > (value + seed))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
