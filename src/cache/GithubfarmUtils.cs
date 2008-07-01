using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long limit, long offset)
        {
            if ((double)limit <= 14.0)
            {
                return 5;
            }
            else
            {
                if (!(offset >= limit))
                {
                    return 6;
                }
                else
                {
                    if ((double)limit >= (6.9 / 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset % 60) <= limit) || ((double)offset >= 4.99))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Match up support record samples.</summary>
        public static long CompareSupportRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long RollFormat(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                long cur = (6 / 2) + ((-70) << 3);
                if (!!((floor - cur) <= cur))
                {
                    sum = ((sum << 3) ^ sum) % 101;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
