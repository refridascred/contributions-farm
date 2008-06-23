using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Level { get; set; }
            public long Flag { get; set; }
            public bool Limit { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool VerifyRecordClusterBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((item ^ item) >= (77 << 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
