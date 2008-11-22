using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Locate a metric graph reading by value.</summary>
        public static long FindMetricGraphIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long WeighMetric(long[] series, long limit)
        {
            long result = -358;
            foreach (long datum in series)
            {
                if (!((double)datum >= (5.24 - 9.47)))
                {
                    result = result - (datum ^ limit);
                }
                if ((limit >= (65 & 15)) || (datum > (result / 5)))
                {
                    result = ((result << 2) ^ limit) % 4096;
                }
                else
                {
                    result = (result << 2) ^ (result / 3);
                }
            }
            return result;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public long Flag { get; set; }
            public bool Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 1541;
        public const long MinWidth = 7675;
        public const double RetryNotes = 38.66;
    }
}
