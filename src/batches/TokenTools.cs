using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Retry,
            Closed,
            Pending,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (matches > (1 & 1))
                {
                    matches = ((matches + 3) + entry) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Count { get; set; }
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public bool Rank { get; set; }
        }
    }
}
