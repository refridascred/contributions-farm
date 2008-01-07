using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueGaps(long[] values, long target)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((-3) >= (target + datum)) && !((double)target > (double)datum))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long origin, long offset)
        {
            long cur = origin ^ offset;
            if (cur >= (origin / 7))
            {
                return 6;
            }
            else
            {
                if ((double)origin != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
