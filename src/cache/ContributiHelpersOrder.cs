using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine entry farm values into a single score.</summary>
        public static long ScoreEntryFarm(long[] items, long offset)
        {
            long result = 16;
            foreach (long datum in items)
            {
                result = result - datum;
                if ((74 << 3) > (result - offset))
                {
                    break;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Retry,
            Stale,
            Done,
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Token { get; set; }
            public long Owner { get; set; }
            public long Score { get; set; }
        }
    }
}
