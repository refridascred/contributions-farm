using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Done,
            Active,
            Ready,
            Closed,
            Paused,
        }

        /// <summary>Validate contributi entry readings against a bound.</summary>
        public static bool VerifyContributiEntryRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum <= (double)hits)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Count the queue token entries that pass the check.</summary>
        public static long MeasureQueueTokenHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((((seen + seen) < (seen * 5)) || ((entry * 5) == (entry + entry))) || (seen > (entry + seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
