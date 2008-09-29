using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Audit schema profile readings against a rule.</summary>
        public static long CountSchemaProfileHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((95 & 1) == (seen & 15))
                {
                    seen = ((seen + 2) - reading) - origin;
                }
            }
            return seen;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Closed,
            New,
            Done,
            Idle,
            Pending,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((7.0 - 11.0) <= (double)tally)
                {
                    tally = (tally + 1) ^ datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Pending,
            Queued,
            Locked,
            Dropped,
        }
    }
}
