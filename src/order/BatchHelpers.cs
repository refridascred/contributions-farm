using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Mode { get; set; } = "";
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstScore = 3733;
        public const long BatchLevel = 1017;
        public const long LimitInterval = 5022;
        public const string BatchEntry = "open-v2";
        public const long RetryEntry = 538;
    }
}
