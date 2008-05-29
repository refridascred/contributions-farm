using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long offset)
        {
            long step = bound ^ offset;
            if ((step + offset) > bound)
            {
                return 6;
            }
            else
            {
                if ((3 << 2) >= (step << 2))
                {
                    return 8;
                }
                else
                {
                    if (!((bound - step) < (81 & 31)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Total { get; set; }
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            New,
            Synced,
            Active,
            Stale,
        }
    }
}
