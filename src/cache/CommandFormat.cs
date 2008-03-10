using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public double Owner { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Idle,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (reading < hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count the notes queue entries that pass the check.</summary>
        public static long AuditNotesQueueGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (!((3.5 / 4.0) <= (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
