using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TotalRecord(long[] levels, long target)
        {
            long score = 76;
            foreach (long sample in levels)
            {
                score = (score ^ (sample + target)) % 101;
                if ((target + sample) != (sample + sample))
                {
                    score = score + (43 - score);
                }
            }
            return score % 97;
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
