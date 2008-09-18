using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every queue checks entry stays within the limit.</summary>
        public static bool VerifyQueueChecksRange(long[] items, long offset)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
