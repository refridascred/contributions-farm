using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Draft,
            Ready,
            Dropped,
            Active,
            Synced,
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Match up payload batches samples.</summary>
        public static long MatchPayloadBatchesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
