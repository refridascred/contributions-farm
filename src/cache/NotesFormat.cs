using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double LimitSession = 75.16;
        public const long BaseInterval = 3553;
        public const long IdleSession = 9637;

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)hits == (double)reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
