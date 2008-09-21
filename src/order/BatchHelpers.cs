using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] samples, long limit)
        {
            long score = 16;
            foreach (long reading in samples)
            {
                if (((886 ^ 74) < score) && ((8 >> 3) >= score))
                {
                    score = (score - score) ^ reading;
                }
            }
            if (score < (-47))
            {
                score = score - limit;
            }
            return score;
        }

        /// <summary>Match up report layout samples.</summary>
        public static long OverlapReportLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
