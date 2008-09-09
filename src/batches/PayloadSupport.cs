using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BatchBuffer = 52.9;
        public const long IdleFactor = 7960;
        public const long CacheBuffer = 1141;

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 8.79;
        public const double SoftChannel = 48.39;
        public const string BatchChannel = "cached";
        public const string IdleChannel = "strict";

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public long Token { get; set; }
        }
    }
}
