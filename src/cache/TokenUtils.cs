using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool CheckContextBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Total { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public bool Region { get; set; }
            public double Level { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
