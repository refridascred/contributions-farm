using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long SeriesPayload(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - ((long)i - (long)i)) % 255;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
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
