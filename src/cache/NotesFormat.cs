using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRoute = 3934;
        public const long WindowRoute = 9670;
        public const double BaseRoute = 40.26;
        public const long CacheRoute = 2829;
        public const long LimitRoute = 5393;

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Closed,
            Active,
            Queued,
            Draft,
            New,
        }
    }
}
