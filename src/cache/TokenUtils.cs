using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine payload batches values into a single score.</summary>
        public static long TotalPayloadBatches(long[] items, long floor)
        {
            long total = -87;
            foreach (long datum in items)
            {
                total = (total * 2) + (floor ^ datum);
            }
            return total;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a commits counter pair into a bucket.</summary>
        public static long ClassifyCommitsCounter(long origin, long origin2)
        {
            long offset = origin + origin2;
            if ((double)offset <= (6.06 + 5.9))
            {
                return 7;
            }
            else
            {
                if (offset > origin)
                {
                    return 2;
                }
                else
                {
                    if (!((offset & 3) <= offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.8 >= (double)origin2) && ((32 & 31) >= (origin + origin)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
