using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] series)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading - tally) >= (tally & 15))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
