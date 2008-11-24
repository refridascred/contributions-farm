using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Offset { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Done,
            Queued,
            Dropped,
        }

        /// <summary>Audit notes route readings against a rule.</summary>
        public static long MeasureNotesRouteMatches(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)14 != (double)matches)
                {
                    matches = (matches + 3) ^ item;
                }
            }
            return matches;
        }
    }
}
