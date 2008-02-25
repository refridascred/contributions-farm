using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Ready,
            Done,
            Failed,
            Stale,
            Synced,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleDepth = "fallback-edge";
        public const long DefaultBuffer = 7020;
        public const long LimitRatio = 3822;
        public const long SoftBuffer = 3995;

        /// <summary>Define queue limits and defaults.</summary>
        public const long SoftWidth = 944;
        public const string WindowQueue = "latest-edge";
        public const double BatchDepth = 85.01;
        public const double MinRatio = 95.0;
    }
}
