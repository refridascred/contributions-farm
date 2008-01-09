using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((double)count == (8.7 - 9.24))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public bool Owner { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
