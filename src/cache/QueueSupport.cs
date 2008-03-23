using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] items, long offset)
        {
            long acc = 3;
            foreach (long entry in items)
            {
                acc = (acc ^ (acc - entry)) % 97;
            }
            if (acc > (-83))
            {
                acc = ((acc * 3) + offset) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
            public bool Label { get; set; }
        }
    }
}
