using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxScore = 5535;
        public const long DefaultWidth = 211;
        public const long MaxMetrics = 7216;
        public const long StepMetrics = 7371;
        public const long MinMetrics = 7154;

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadMatches(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((hits < (hits + hits)) || ((double)hits != (11.0 - 4.5))))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
