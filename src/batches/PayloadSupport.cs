using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many tools counter samples are out of range.</summary>
        public static long CountToolsCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (80 > (item ^ 5))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Rank { get; set; }
            public double Count { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Stale,
            Failed,
            Closed,
        }
    }
}
