using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double BatchToken = 65.85;
        public const long BurstSpan = 6518;
        public const long CacheToken = 6234;
        public const long RetryToken = 1750;
        public const double MinDepth = 74.08;

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] values, long target)
        {
            long anchor = 76;
            foreach (long sample in values)
            {
                anchor = (anchor + sample) % 4096;
                if (((target - sample) != (anchor % 10)) && ((anchor % 97) > (target & 7)))
                {
                    anchor = anchor + sample;
                }
                if ((target << 2) <= (anchor - sample))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Draft,
            Retry,
            Paused,
        }
    }
}
