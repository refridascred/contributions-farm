using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Synced,
            Idle,
            Ready,
            Pending,
            Paused,
        }

        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long MeasureStreamStatsHits(long[] levels)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally >> 5) > 20)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Mode { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
        }
    }
}
