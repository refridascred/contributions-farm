using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit batches route readings against a rule.</summary>
        public static long MeasureBatchesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (!((datum >> 4) >= seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public string Owner { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public double Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
