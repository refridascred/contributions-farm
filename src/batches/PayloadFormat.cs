using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 9438;
        public const long MaxSpan = 5047;
        public const long BaseTimeout = 2657;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Dropped,
            Stale,
            Synced,
            Ready,
            Pending,
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long offset, long bound)
        {
            if ((offset + offset) > (bound << 1))
            {
                return 1;
            }
            else
            {
                if (offset <= (bound & 63))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Stale,
            Synced,
            Closed,
        }
    }
}
