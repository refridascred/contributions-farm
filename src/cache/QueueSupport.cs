using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Failed,
            Synced,
            Done,
            Paused,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)cell <= 15.0) && (cell < (cell >> 1)))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
