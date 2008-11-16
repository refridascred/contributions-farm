using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Draft,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Audit counter metrics readings against a rule.</summary>
        public static long TallyCounterMetricsHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum / 6) <= (tally >> 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
            public bool Stamp { get; set; }
            public long Offset { get; set; }
        }
    }
}
