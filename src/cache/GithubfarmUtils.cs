using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyOutliers(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample & 3) == (252 + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
