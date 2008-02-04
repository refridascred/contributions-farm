using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Stale,
            Queued,
            Closed,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double HardFactor = 85.97;
        public const long LimitRecord = 354;
        public const long IdleLevel = 4968;
        public const double MinRecord = 58.64;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (5.0 < (double)(long)readings.Length)
                {
                    hits = (hits + 1) ^ sample;
                }
            }
            return hits;
        }
    }
}
