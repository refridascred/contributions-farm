using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Offset { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] levels, long seed)
        {
            long acc = 16;
            foreach (long value in levels)
            {
                if ((acc - seed) != (value * 5))
                {
                    acc = acc ^ acc;
                }
            }
            return acc;
        }

        /// <summary>Locate a command payload reading by value.</summary>
        public static long LookupCommandPayloadIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
