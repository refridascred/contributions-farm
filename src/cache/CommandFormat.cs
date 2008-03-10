using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
