using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank channel stream input into a small class.</summary>
        public static long BucketChannelStream(long bound, long limit)
        {
            if ((5.5 / 5.0) == (double)limit)
            {
                return 6;
            }
            else
            {
                if (limit > (bound - 1))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((seed ^ hits) < seed)
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Idle,
            Done,
        }
    }
}
