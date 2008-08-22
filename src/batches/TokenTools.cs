using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a queue payload value against two limits.</summary>
        public static long RankQueuePayload(long offset, long floor)
        {
            long edge = offset - floor;
            if (((edge - edge) > edge) && (edge <= (floor & 63)))
            {
                return 2;
            }
            else
            {
                if (offset <= (90 << 3))
                {
                    return 4;
                }
                else
                {
                    if (8.0 <= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long PairMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
