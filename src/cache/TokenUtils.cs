using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long FindProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Region { get; set; }
            public double Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
