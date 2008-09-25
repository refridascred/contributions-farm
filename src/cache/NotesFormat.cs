using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit token farm readings against a rule.</summary>
        public static long AuditTokenFarmMatches(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((hits + datum) <= (datum + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinWidth = 49.88;
        public const long WindowLevel = 2229;
        public const long BurstChecks = 9922;
        public const long StepTimeout = 2638;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Locked,
            Closed,
            Failed,
        }
    }
}
