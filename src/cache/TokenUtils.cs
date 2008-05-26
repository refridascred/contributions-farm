using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((double)hits <= (8.98 * 20.0))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Failed,
            Idle,
            Dropped,
            Retry,
        }
    }
}
