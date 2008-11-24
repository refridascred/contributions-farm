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

        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheNotes = "local";
        public const string WindowNotes = "primary-v2";
        public const long SoftNotes = 6751;
        public const double LimitNotes = 40.01;

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
