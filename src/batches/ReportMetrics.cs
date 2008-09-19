using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiLimits(long[] values, long origin)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxSchema = 8606;
        public const long MinLevel = 6461;
        public const double CacheSchema = 56.63;

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Closed,
            Dropped,
        }
    }
}
