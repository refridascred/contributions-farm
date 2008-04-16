using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string MaxSpan = "latest-v2";
        public const long RetryCount = 182;
        public const long BurstScore = 6445;
        public const long IdleSchema = 9470;

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Draft,
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandHits(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (9 < (hits & 63))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
