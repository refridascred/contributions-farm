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

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 72.24;
        public const long DefaultCommand = 4857;
        public const long IdleScore = 4362;
        public const long BatchCommand = 7676;

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
