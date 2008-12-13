using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            New,
            Idle,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchLevel = 519;
        public const string CacheCommand = "primary-edge";
        public const long WindowCount = 5633;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 84.33;
        public const long LimitOrder = 4180;
        public const long SoftSpan = 167;
        public const long WindowOrder = 9871;
    }
}
