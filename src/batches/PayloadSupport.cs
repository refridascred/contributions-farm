using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountMatches(long[] items, long origin)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((2.8 - 2.23) != (double)origin)
                {
                    seen = (seen + 1) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 84.93;
        public const long BurstWidth = 2914;
        public const long SoftInterval = 2770;
        public const long DefaultTimeout = 7523;
        public const long MinInterval = 9423;

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Locked,
            Queued,
            Failed,
        }
    }
}
