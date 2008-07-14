using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Level { get; set; }
            public bool Flag { get; set; }
            public bool Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (seen < floor)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Roll a metrics token counter forward.</summary>
        public static long SeriesMetricsToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    acc = ((acc << 3) ^ acc) - (long)i2;
                }
                acc = acc ^ seed;
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
