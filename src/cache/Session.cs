using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc + (578 % 5)) % 4096;
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (hits >= (hits - entry))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Paused,
            Draft,
            Done,
            Stale,
            Idle,
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            New,
            Queued,
        }
    }
}
