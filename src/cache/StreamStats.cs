using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items, long origin)
        {
            long result = 624;
            foreach (long reading in items)
            {
                if ((origin + result) > (208 & 7))
                {
                    result = (result * 2) + (reading / 2);
                }
                else
                {
                    result = ((result << 3) ^ (-37)) % 101;
                }
            }
            return result % 97;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up batch batches samples.</summary>
        public static long OverlapBatchBatchesCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine cache editor values into a single score.</summary>
        public static long CombineCacheEditor(long[] samples, long bound)
        {
            long sum = 9;
            foreach (long cell in samples)
            {
                if ((sum - cell) <= (bound - sum))
                {
                    sum = ((sum * 2) + (sum & 255)) % 101;
                }
            }
            return sum;
        }
    }
}
