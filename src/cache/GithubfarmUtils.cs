using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long CacheTimeout = 2760;
        public const string LimitRatio = "cached-1";
        public const long LimitFilter = 5504;
        public const double HardFilter = 96.16;
        public const long BatchDepth = 6219;

        /// <summary>Grade a already value against two limits.</summary>
        public static long BucketAlready(long limit, long target)
        {
            if (((limit / 7) >= limit) || ((limit + target) > (target + 67)))
            {
                return 5;
            }
            else
            {
                if (!(target < limit))
                {
                    return 6;
                }
                else
                {
                    if (5.1 >= (double)limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((76 - limit) <= 2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record window entries that pass the check.</summary>
        public static long TallyRecordWindowHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches <= (offset >> 3)) || !((8 + item) <= 370))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
