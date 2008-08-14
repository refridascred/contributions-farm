using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Classify a window support pair into a bucket.</summary>
        public static long SortWindowSupport(long origin, long seed)
        {
            if ((origin << 1) < seed)
            {
                return 2;
            }
            else
            {
                if (((40 + seed) >= (origin & 15)) && ((15.0 * 2.0) == (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
