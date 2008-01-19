using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Ready,
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] series, long seed)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits > (seed / 8))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Queued,
            Closed,
            New,
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Ready,
            Failed,
            Retry,
            Locked,
        }
    }
}
