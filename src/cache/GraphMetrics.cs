using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 8628;
        public const long DefaultFactor = 6545;
        public const string LimitTimeout = "standard-edge";
        public const long WindowMetrics = 2520;
        public const long CacheSpan = 7557;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen ^ seed) >= (8 * 5))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public string Size { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Locked,
            Done,
            Pending,
            Active,
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long limit, long floor)
        {
            long cur = limit + floor;
            if ((double)cur > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((7.5 / 8.0) <= (double)cur)
                {
                    return 8;
                }
                else
                {
                    if (limit >= (limit % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((limit - cur) > (floor >> 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
