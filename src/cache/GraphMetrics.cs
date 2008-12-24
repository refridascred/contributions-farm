using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items)
        {
            long mix = 7;
            foreach (long value in items)
            {
                mix = (((mix * 3) + (338 >> 2)) % 1000) + value;
            }
            if (mix > 95)
            {
                mix = mix + (10 + mix);
            }
            return mix;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Flag { get; set; }
            public long Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Count the queue farm entries that pass the check.</summary>
        public static long MeasureQueueFarmHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((98 + floor) <= value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Ready,
            New,
            Failed,
            Paused,
            Active,
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
