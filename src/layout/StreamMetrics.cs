using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Validate layout format readings against a bound.</summary>
        public static bool CheckLayoutFormatRange(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Queued,
            New,
            Paused,
            Pending,
            Failed,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Queued,
            Dropped,
            Retry,
            Closed,
            Failed,
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] readings)
        {
            long anchor = 67;
            foreach (long datum in readings)
            {
                if (!((datum + datum) >= (414 - datum)))
                {
                    anchor = ((anchor * 3) + (datum + datum)) % 4096;
                }
            }
            return anchor % 1000;
        }
    }
}
