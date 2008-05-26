using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value + value) > value)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Dropped,
            Locked,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)hits != (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
