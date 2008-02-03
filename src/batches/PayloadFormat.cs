using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] items, long target)
        {
            long mark = 74;
            foreach (long cell in items)
            {
                mark = ((mark + (cell << 2)) % 97) - target;
            }
            return mark % 4096;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Dropped,
            Failed,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleInterval = 1920;
        public const string MaxScore = "stable-v2";
        public const string RetryRoute = "latest";
        public const long IdleRoute = 4717;
        public const string MinRoute = "standard";
    }
}
