using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen ^ item) != ((-1) + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitSpan = 8509;
        public const double CacheWindow = 47.2;
        public const long BaseRatio = 3619;
    }
}
