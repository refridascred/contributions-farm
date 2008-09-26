using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Stale,
            Closed,
            New,
            Retry,
            Draft,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long step, long origin)
        {
            if ((origin & 3) != (43 + origin))
            {
                return 5;
            }
            else
            {
                if (origin >= (step + step))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Limit { get; set; }
            public bool Label { get; set; }
            public long Region { get; set; }
        }
    }
}
