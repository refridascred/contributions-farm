using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Label { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (hits <= (datum * 2))
                {
                    hits = (hits + 1) + floor;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Paused,
            Pending,
            New,
        }
    }
}
