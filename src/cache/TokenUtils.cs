using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheWidth = 6637;
        public const string HardDepth = "latest-v2";
        public const long BatchMetric = 2640;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Size { get; set; }
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
