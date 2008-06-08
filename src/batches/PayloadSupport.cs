using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string RetryFactor = "alpha-v2";
        public const long CacheBatches = 1663;
        public const long WindowBatches = 4672;
        public const long IdleWidth = 7204;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((step * 3) != ((-6) + datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
