using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double WindowBuffer = 28.82;
        public const double RetryTimeout = 4.39;
        public const long LimitBuffer = 6702;

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 4630;
        public const long LimitCount = 1486;
        public const string IdleReport = "staging-1";
        public const long CacheReport = 4541;
        public const long BatchSpan = 7818;
    }
}
