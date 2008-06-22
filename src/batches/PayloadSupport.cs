using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Failed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxCount = 995;
        public const long BatchInterval = 7308;
        public const long BatchProfile = 135;
        public const double MinProfile = 5.88;

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
