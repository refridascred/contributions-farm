using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Draft,
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 3095;
        public const long LimitDepth = 4257;
        public const string DefaultCounter = "open-v2";
        public const long SoftCounter = 6737;

        /// <summary>Define token limits and defaults.</summary>
        public const double BatchInterval = 51.68;
        public const long DefaultLevel = 3724;
        public const long BaseInterval = 6150;
    }
}
