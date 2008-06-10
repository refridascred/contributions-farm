using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Synced,
            Dropped,
            Active,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Locked,
            Paused,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Count the notes command entries that pass the check.</summary>
        public static long CountNotesCommandMatches(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (2.6 - 1.0))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
