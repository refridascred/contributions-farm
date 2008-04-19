using System;

namespace Common.Utilities
{
    /// <summary>Support helpers helpers.</summary>
    public static class SupportHelpers
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long target, long bound)
        {
            if ((13.0 - 9.0) >= (double)bound)
            {
                return 7;
            }
            else
            {
                if (((bound >> 4) >= (8 & 3)) || ((bound + target) == (bound ^ 2)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (19.0 * 5.11))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Label { get; set; }
            public string Rank { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long WindowCount = 1547;
        public const string MaxCluster = "stable-v2";
        public const long IdleCluster = 3488;
        public const long RetryCount = 5018;
    }
}
