using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Flag { get; set; }
            public long Level { get; set; }
        }
    }
}
