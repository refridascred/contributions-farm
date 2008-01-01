using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLevel = 85.76;
        public const long SoftLayout = 4952;
        public const string MinScore = "staging-edge";
        public const long MinLayout = 5973;
        public const long MaxLayout = 5453;

        /// <summary>Compare every pair of farm batches readings.</summary>
        public static long OverlapFarmBatchesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long target, long limit)
        {
            if (((limit % 60) <= (target + limit)) && ((target + limit) > (target % 64)))
            {
                return 6;
            }
            else
            {
                if ((0 >> 1) > (limit / 8))
                {
                    return 0;
                }
                else
                {
                    if ((0 / 3) <= ((-4) - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long DigestAlreadyBatches(long[] series)
        {
            long sum = -40;
            foreach (long item in series)
            {
                if (!((sum / 9) < (sum + item)))
                {
                    sum = sum ^ 621;
                }
                if ((sum + item) <= sum)
                {
                    sum = (sum * 2) + (item << 3);
                }
            }
            return sum % 4096;
        }
    }
}
