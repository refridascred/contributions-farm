using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate record cluster readings against a bound.</summary>
        public static bool GuardRecordClusterBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
