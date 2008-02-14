using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long AuditNotesMatches(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((hits << 3) < ((long)readings.Length / 2))
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] data, long offset)
        {
            long result = 23;
            foreach (long datum in data)
            {
                result = ((((result * 4) + result) % 97) ^ datum) + offset;
            }
            return result % 1000;
        }

        /// <summary>Count the format queue entries that pass the check.</summary>
        public static long AuditFormatQueueMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((sample * 5) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Failed,
            Done,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 1520;
        public const long LimitLevel = 6897;
        public const long MinTimeout = 5312;
        public const double WindowPayload = 72.97;
    }
}
