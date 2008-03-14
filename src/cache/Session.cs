using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string MaxWidth = "cached-edge";
        public const double RetryTimeout = 2.1;
        public const string HardCount = "cached-v2";
        public const string RetryProfile = "local-1";
        public const double CacheInterval = 43.58;

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Level { get; set; } = "";
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long bound, long bound2)
        {
            if ((bound >> 1) != (bound2 + 5))
            {
                return 1;
            }
            else
            {
                if (!((bound2 >> 5) < bound))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            if (!(5.0 >= (double)limit))
            {
                return 1;
            }
            else
            {
                if (!((3.83 + 16.0) <= (double)origin))
                {
                    return 2;
                }
                else
                {
                    if ((limit / 3) >= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((14.0 * 3.69) != (double)limit)
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
