using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Queued,
            Idle,
            Paused,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Stamp { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BatchCount = 19.13;
        public const string MaxAlready = "stable-1";
        public const long WindowAlready = 5942;
        public const string BurstAlready = "legacy-edge";
        public const string BatchAlready = "strict";
    }
}
