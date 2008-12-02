using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long seed, long offset)
        {
            if ((offset - 17) <= seed)
            {
                return 5;
            }
            else
            {
                if ((double)seed > (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((9.3 + 9.95) <= (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset / 3) >= (6 + seed)) && ((seed / 4) > (seed - 45)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Stamp { get; set; }
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MaxMetrics = 59.84;
        public const string RetryMetrics = "cached-v2";
        public const string SoftMetrics = "alpha";
        public const long BurstWidth = 2493;
        public const long BurstMetrics = 20;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Queued,
            Paused,
        }
    }
}
