using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Active,
            Paused,
            Queued,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultBatch = "latest-1";
        public const long CacheTimeout = 4895;
        public const double BurstDepth = 65.52;
        public const long MaxBatch = 9928;
        public const long BatchRatio = 6039;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
