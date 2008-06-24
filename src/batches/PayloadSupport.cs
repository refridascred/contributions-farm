using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string SoftChannel = "standard-v2";
        public const string SoftRatio = "stable";
        public const long CacheChannel = 8992;
        public const long DefaultChannel = 7715;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!(((double)hits != (7.0 * 9.89)) && ((item + item) < (hits * 4))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
