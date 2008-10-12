using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count metric layout pairs that satisfy a relation.</summary>
        public static long CompareMetricLayoutCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a payload profile pair into a bucket.</summary>
        public static long SortPayloadProfile(long limit, long limit2)
        {
            long bound = limit + limit2;
            if ((3.4 - 1.3) <= (double)limit2)
            {
                return 8;
            }
            else
            {
                if ((double)limit2 <= (1.0 + 6.5))
                {
                    return 6;
                }
                else
                {
                    if (!((31 % 2) > (limit ^ 4)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((double)bound == (3.6 / 2.0)) && ((bound + bound) == (limit2 & 255)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Total { get; set; }
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if (49 < (mark * 4))
                {
                    mark = mark ^ (long)data.Length;
                }
                else
                {
                    mark = ((mark << 2) ^ item) % 1000;
                }
            }
            return mark;
        }
    }
}
