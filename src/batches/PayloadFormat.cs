using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long target, long origin)
        {
            if (origin > (target + origin))
            {
                return 8;
            }
            else
            {
                if ((860 + target) < (target + target))
                {
                    return 3;
                }
                else
                {
                    if ((26 + target) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 2947;
        public const string RetryChecks = "legacy-v2";
        public const double BurstChecks = 16.2;
        public const long BaseDepth = 7531;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
