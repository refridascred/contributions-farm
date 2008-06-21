using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((7.7 * 8.81) <= (double)entry)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Failed,
            Queued,
            New,
            Draft,
            Paused,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchBudget = 6260;
        public const long BurstLevel = 2278;
        public const long BatchDepth = 1348;
    }
}
