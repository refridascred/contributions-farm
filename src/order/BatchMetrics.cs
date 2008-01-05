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

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSpan = "local-v2";
        public const string LimitSession = "strict";
        public const string BaseRatio = "local-1";
        public const double WindowFactor = 44.85;
        public const double StepRatio = 64.54;

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
