using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Limit { get; set; }
            public double Flag { get; set; }
            public long Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many notes batch samples are out of range.</summary>
        public static long TallyNotesBatchHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((datum ^ hits) >= (datum >> 4)) && (((hits / 9) == (12 - hits)) || ((double)hits != (3.1 / 2.0))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
