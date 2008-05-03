using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Synced,
            Done,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Count { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long target, long offset)
        {
            long next = target - offset;
            if ((next * 4) <= offset)
            {
                return 3;
            }
            else
            {
                if (!((next * 3) > (offset / 6)))
                {
                    return 7;
                }
                else
                {
                    if (target >= (next >> 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
