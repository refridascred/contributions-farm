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

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 1859;
        public const long BurstRecord = 3759;
        public const long WindowRecord = 9609;
        public const long BatchRatio = 1255;
    }
}
