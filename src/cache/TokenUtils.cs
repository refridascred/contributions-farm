using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if (((-44) + hits) > (hits + entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Pending,
            Active,
            Done,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry > (15.0 - 17.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }
    }
}
