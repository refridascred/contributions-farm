using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string HardOrder = "alpha";
        public const long BurstBudget = 8868;
        public const double RetryOrder = 5.82;

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheToken = 5237;
        public const long IdleToken = 1318;
        public const long WindowBudget = 3285;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Locked,
            Done,
            Stale,
            Failed,
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public bool Token { get; set; }
            public bool Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long offset, long origin)
        {
            if (!((double)offset >= (double)origin))
            {
                return 0;
            }
            else
            {
                if ((origin >> 3) > (offset >> 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin > (6.11 + 16.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset + 8) >= offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
