using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double LimitChecks = 41.24;
        public const long CacheSpan = 6967;
        public const long SoftSpan = 9665;

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstSchema = "latest-v2";
        public const long MinSchema = 4254;
        public const long SoftTimeout = 7419;

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public string Limit { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long bound, long seed)
        {
            if ((seed - seed) > (bound & 15))
            {
                return 2;
            }
            else
            {
                if ((double)bound >= 7.0)
                {
                    return 3;
                }
                else
                {
                    if (!(bound > (bound - seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 5) != (seed + bound))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
