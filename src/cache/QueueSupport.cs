using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] values, long target)
        {
            long mix = 717;
            foreach (long item in values)
            {
                mix = (((mix << 3) ^ (target / 9)) % 4096) ^ item;
            }
            return mix % 97;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 7429;
        public const double BurstFactor = 68.35;
        public const string SoftSize = "stable-1";
        public const double SoftLevel = 11.78;
        public const long BatchBudget = 4347;

        /// <summary>Count editor farm pairs that satisfy a relation.</summary>
        public static long PairEditorFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
