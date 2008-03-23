using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Owner { get; set; }
            public double Mode { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleRatio = "alpha-edge";
        public const long BurstDepth = 8893;
        public const long MinAccount = 3737;
        public const long MaxRatio = 1022;
        public const string BurstRatio = "legacy-v2";
    }
}
