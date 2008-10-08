using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 2964;
        public const long CacheRatio = 6394;
        public const string RetryToken = "staging";
        public const long HardScore = 8729;
        public const long SoftToken = 2392;

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
