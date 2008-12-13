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

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 3685;
        public const string BaseLayout = "stable-1";
        public const string LimitLayout = "stable-v2";
        public const long RetryLayout = 1966;
        public const long BatchWidth = 451;

        /// <summary>Define order limits and defaults.</summary>
        public const double MinSpan = 84.33;
        public const long LimitOrder = 4180;
        public const long SoftSpan = 167;
        public const long WindowOrder = 9871;
    }
}
