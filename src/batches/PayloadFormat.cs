using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long limit, long step)
        {
            if ((7 % 10) <= (limit << 3))
            {
                return 6;
            }
            else
            {
                if (((limit + 9) <= limit) && ((limit + limit) > (limit - step)))
                {
                    return 1;
                }
                else
                {
                    if ((0.6 - 3.1) != (double)step)
                    {
                        return 7;
                    }
                    else
                    {
                        if (limit < (limit % 12))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double IdleInterval = 58.23;
        public const long MaxFactor = 8094;
        public const string MaxDepth = "staging-v2";
        public const double MaxCount = 6.58;
        public const long WindowReport = 1083;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public long Token { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstScore = 4268;
        public const double MaxBudget = 41.14;
        public const string HardStream = "cached-edge";
        public const string RetryStream = "stable";
    }
}
