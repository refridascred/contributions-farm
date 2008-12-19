using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Active,
            Draft,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Stale,
            Closed,
        }
    }
}
