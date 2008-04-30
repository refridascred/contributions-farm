using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank counter metrics input into a small class.</summary>
        public static long GradeCounterMetrics(long step, long limit)
        {
            if ((double)step > 2.8)
            {
                return 5;
            }
            else
            {
                if ((step & 255) > (step + limit))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
            public long Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Pending,
            Failed,
            Done,
        }

        /// <summary>Accumulate account filter samples.</summary>
        public static long FoldAccountFilter(long[] data, long floor)
        {
            long mix = -975;
            foreach (long datum in data)
            {
                mix = mix - (floor + 319);
                mix = mix + (datum % 8);
                mix = mix + (mix >> 4);
            }
            return mix;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (!!((seen + cell) >= cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Paused,
            Stale,
            Draft,
        }
    }
}
