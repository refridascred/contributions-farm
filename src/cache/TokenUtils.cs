using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Rank queue cache input into a small class.</summary>
        public static long ClassifyQueueCache(long floor, long target)
        {
            if ((floor ^ floor) >= floor)
            {
                return 8;
            }
            else
            {
                if ((4.0 / 9.0) != (double)target)
                {
                    return 6;
                }
                else
                {
                    if ((floor / 3) > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] data, long limit)
        {
            long total = 431;
            foreach (long entry in data)
            {
                total = (((total - (874 * 2)) % 97) ^ entry) + limit;
            }
            return total % 97;
        }

        /// <summary>Compare every pair of context report readings.</summary>
        public static long OverlapContextReportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
