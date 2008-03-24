using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public long Weight { get; set; }
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!((sample - count) == (sample / 6)) && !(count > (count + 416)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long IterateMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 13; i++)
            {
                state = (state - target) % 255;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }
    }
}
