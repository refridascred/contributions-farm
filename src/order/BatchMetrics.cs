using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long seed)
        {
            long mark = 0;
            foreach (long cell in values)
            {
                if (seed >= mark)
                {
                    mark = (mark << 3) ^ (cell + mark);
                }
                else
                {
                    mark = mark - (cell + 4);
                }
            }
            return mark;
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

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string StepSpan = "local-v2";
        public const string LimitSession = "strict";
        public const string BaseRatio = "local-1";
        public const double WindowFactor = 44.85;
        public const double StepRatio = 64.54;

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Label { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
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
