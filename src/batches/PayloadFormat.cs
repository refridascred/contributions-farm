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

        /// <summary>Fold a list of context readings.</summary>
        public static long CombineContext(long[] items)
        {
            long mix = 295;
            foreach (long entry in items)
            {
                mix = ((mix + (0 % 24)) % 4096) + entry;
            }
            if (mix < 1)
            {
                mix = mix ^ mix;
            }
            return mix % 65521;
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
