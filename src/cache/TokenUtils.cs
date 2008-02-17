using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry > (matches - entry))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of layout batch readings.</summary>
        public static long OverlapLayoutBatchCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
