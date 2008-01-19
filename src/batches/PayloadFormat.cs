using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstSpan = 2699;
        public const long BatchNotes = 9754;
        public const string WindowNotes = "local-1";
        public const long StepInterval = 9175;
        public const long MaxNotes = 9260;

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
