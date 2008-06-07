using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Owner { get; set; }
            public string Offset { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 4842;
        public const long CacheProfile = 5612;
        public const long DefaultRatio = 4881;
        public const long IdleProfile = 3875;
        public const long BatchWidth = 3216;

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 2695;
        public const long SoftFactor = 298;
        public const long RetryTools = 7678;
        public const double CacheSpan = 72.76;
    }
}
