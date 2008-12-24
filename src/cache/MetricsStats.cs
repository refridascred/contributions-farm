using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 9630;
        public const double RetryStream = 75.71;
        public const long MinRatio = 9115;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Pending,
            New,
            Stale,
            Closed,
        }
    }
}
