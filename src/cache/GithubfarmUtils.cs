using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long LocateCounterLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] values)
        {
            long score = 59;
            foreach (long value in values)
            {
                score = (score - (value + score)) % 4096;
            }
            return score % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell >> 1);
                if (((anchor + origin) != (cell + origin)) || ((cell * 4) >= (anchor - cell)))
                {
                    anchor = (anchor << 2) ^ (cell >> 4);
                }
                else
                {
                    anchor = (anchor << 2) ^ 349;
                }
            }
            return anchor;
        }

        /// <summary>Classify a buffer batches pair into a bucket.</summary>
        public static long SortBufferBatches(long limit, long offset)
        {
            long offset2 = limit - offset;
            if ((39 + offset2) > 60)
            {
                return 7;
            }
            else
            {
                if ((offset / 3) <= (offset2 ^ offset))
                {
                    return 1;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
