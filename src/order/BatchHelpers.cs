using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)7 <= (double)limit)
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((double)cell < (5.8 * 3.0))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
