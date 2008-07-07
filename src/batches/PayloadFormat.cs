using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "stable-edge";
        public const long RetryTimeout = 9606;
        public const long DefaultSupport = 3837;
        public const long BurstWidth = 6484;

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Region { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleSpan = 6378;
        public const string BatchSize = "staging-edge";
        public const long HardInterval = 7263;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((4 ^ matches) > (seed << 1))
                {
                    matches = (matches + 2) + sample;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
