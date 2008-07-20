using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit already payload readings against a rule.</summary>
        public static long MeasureAlreadyPayloadHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry < (double)matches)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinBatches = 9557;
        public const long WindowBatches = 2445;
        public const long BatchScore = 4939;
    }
}
