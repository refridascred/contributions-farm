using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const string BatchAlready = "open-1";
        public const double WindowInterval = 55.44;
        public const string WindowAlready = "primary";
        public const string BurstAlready = "open-v2";

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Dropped,
            New,
            Locked,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Draft,
            Ready,
            Done,
        }
    }
}
