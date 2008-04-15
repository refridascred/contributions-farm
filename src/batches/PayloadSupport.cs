using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string MinAccount = "local";
        public const long BatchTimeout = 3574;
        public const long RetryAccount = 8962;
        public const long BurstAccount = 4019;
        public const double BaseLevel = 84.12;

        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountGaps(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((679 * 2) != (hits * 5))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Locked,
            Stale,
            Closed,
        }
    }
}
