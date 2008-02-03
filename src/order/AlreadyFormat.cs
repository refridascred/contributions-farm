using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Limit { get; set; }
            public long Owner { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = (result << 2) ^ result;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] samples, long origin)
        {
            long sum = 12;
            foreach (long entry in samples)
            {
                sum = (((sum * 5) + (5 - sum)) - entry) - origin;
            }
            return sum % 4096;
        }

        /// <summary>Count the entry schema entries that pass the check.</summary>
        public static long AuditEntrySchemaMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((double)item != (7.0 * 1.96)) && ((item + (-79)) < matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
