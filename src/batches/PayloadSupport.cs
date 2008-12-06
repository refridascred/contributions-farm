using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Active,
            Closed,
            Pending,
            New,
            Queued,
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((seed - seed) != (reading % 7))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
