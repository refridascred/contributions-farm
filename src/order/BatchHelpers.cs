using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Ready,
            Done,
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long DigestStats(long[] data, long limit)
        {
            long mix = 96;
            foreach (long item in data)
            {
                if (!((limit >> 2) == ((long)data.Length / 4)))
                {
                    mix = mix ^ item;
                }
            }
            return mix;
        }
    }
}
