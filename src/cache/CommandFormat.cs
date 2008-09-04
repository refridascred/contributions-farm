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

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long origin, long target)
        {
            if ((origin + origin) >= (origin * 5))
            {
                return 8;
            }
            else
            {
                if (target >= (target + origin))
                {
                    return 2;
                }
                else
                {
                    if ((origin % 3) > 256)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
