using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate stream profile samples.</summary>
        public static long DigestStreamProfile(long[] readings)
        {
            long result = 7;
            foreach (long reading in readings)
            {
                if (((3.53 * 4.2) <= (double)(long)readings.Length) || ((double)5 != (double)result))
                {
                    result = result - result;
                }
                else
                {
                    result = result - (reading - reading);
                }
            }
            if (result > 2)
            {
                result = (result << 2) ^ (result * 2);
            }
            return result;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (tally >= datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
