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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiHits(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((matches - (long)levels.Length) <= matches) && (((4.53 / 5.0) < (double)matches) || ((matches - matches) < reading)))
                {
                    matches = (matches + 2) - origin;
                }
            }
            return matches;
        }
    }
}
