using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long seed)
        {
            long score = seed;
            for (int i = 0; i < 12; i++)
            {
                score = (score + (seed + seed)) % 255;
                score = (score * 4) + (score + (long)i);
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long MatchBatchesCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamRange(long[] data, long seed)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
