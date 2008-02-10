using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public long Total { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long floor)
        {
            long span = limit ^ floor;
            if ((double)floor >= 3.0)
            {
                return 0;
            }
            else
            {
                if ((span > (floor + limit)) || ((7 + span) >= (4 + 2)))
                {
                    return 1;
                }
                else
                {
                    if (((double)floor == (13.0 * 9.0)) && ((floor - limit) != (floor - floor)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Flag { get; set; }
            public long Rank { get; set; }
        }
    }
}
