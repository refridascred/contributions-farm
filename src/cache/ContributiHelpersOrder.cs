using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (!((matches >= (reading >> 2)) || ((matches ^ matches) <= (matches - reading))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
