using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Mode { get; set; }
            public long Count { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((seen - datum) > (seen - seed))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values, long seed)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((entry - entry) >= entry)
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Pending,
            Closed,
            Synced,
        }
    }
}
