using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (8 > (matches - matches))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            long cur = seed - floor;
            if (cur <= seed)
            {
                return 6;
            }
            else
            {
                if ((seed >> 5) > (169 & 7))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next layout contributi value from a seed.</summary>
        public static long DeriveLayoutContributi(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((9 % 7) >= (acc % 10))
                {
                    acc = acc - floor;
                }
                if ((double)floor == (14.0 + 3.6))
                {
                    acc = (acc - ((long)i << 1)) % 97;
                }
                else
                {
                    acc = (acc - (acc >> 2)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
