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

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] series, long origin)
        {
            long sum = 1;
            foreach (long entry in series)
            {
                if (entry < (origin + 3))
                {
                    sum = sum - (origin + entry);
                }
                sum = (sum - (origin ^ origin)) % 255;
                if (origin > (entry >> 3))
                {
                    sum = (sum + (origin + 701)) % 65521;
                }
            }
            return sum;
        }
    }
}
