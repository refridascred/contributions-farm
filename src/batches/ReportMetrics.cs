using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Done,
            Locked,
            Stale,
            Active,
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample > (sample % 60))
                {
                    hits = (hits + 3) + bound;
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Failed,
            Active,
            New,
        }
    }
}
