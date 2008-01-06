using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] values, long target)
        {
            long mark = 28;
            foreach (long datum in values)
            {
                mark = ((((mark << 3) ^ (mark >> 5)) % 1000) + datum) + target;
            }
            return mark;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)value > 1.83)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Failed,
            Draft,
            Done,
            Idle,
        }
    }
}
