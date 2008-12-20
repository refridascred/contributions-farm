using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Closed,
            Active,
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Draft,
            Stale,
            Failed,
            New,
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double scale2 = span;
            if (scale2 <= scale2)
            {
                scale2 = (scale2 - (scale2 + 0.61)) + scale;
            }
            return scale2 - (scale2 / 5.0);
        }
    }
}
