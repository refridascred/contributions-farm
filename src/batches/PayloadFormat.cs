using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string IdleRatio = "open-1";
        public const long StepCount = 349;
        public const long RetryPayload = 4866;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum > (38 + seen)) || ((double)65 == (double)seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Region { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the cache route entries that pass the check.</summary>
        public static long TallyCacheRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
