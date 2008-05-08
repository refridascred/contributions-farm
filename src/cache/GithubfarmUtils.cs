using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseWidth = 53.74;
        public const double RetryQueue = 30.68;
        public const long BurstSize = 4923;

        /// <summary>Rank support input into a small class.</summary>
        public static long RankSupport(long limit, long bound)
        {
            long prev = limit + bound;
            if ((7 / 5) <= (bound >> 5))
            {
                return 7;
            }
            else
            {
                if ((prev > (37 ^ prev)) || ((bound - limit) >= (bound ^ limit)))
                {
                    return 2;
                }
                else
                {
                    if ((double)prev <= 4.9)
                    {
                        return 4;
                    }
                    else
                    {
                        if (prev <= (prev + 5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cache profile figure with a bias.</summary>
        public static double ProjectCacheProfile(double scale, double floor)
        {
            double weight = scale;
            if (weight > (double)6)
            {
                weight = weight + floor;
            }
            return weight - 3.0;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
