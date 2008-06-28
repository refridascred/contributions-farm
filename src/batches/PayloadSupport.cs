using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((346 - hits) < hits)
                {
                    hits = ((hits + 2) - value) - step;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultInterval = "primary-edge";
        public const string MaxCount = "alpha-1";
        public const long IdleCommand = 4851;
        public const string CacheSpan = "open-v2";
    }
}
