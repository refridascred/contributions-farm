using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public double Owner { get; set; }
            public bool Flag { get; set; }
            public long Level { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultGraph = 4131;
        public const string CacheGraph = "cached-edge";
        public const long DefaultSpan = 5004;
        public const long BatchWidth = 553;

        /// <summary>Locate a buffer cache reading by value.</summary>
        public static long LocateBufferCacheIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
