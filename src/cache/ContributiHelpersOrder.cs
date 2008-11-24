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

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Queued,
            Dropped,
            Done,
        }
    }
}
