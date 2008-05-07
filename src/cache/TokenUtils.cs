using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 2608;
        public const long IdleCommand = 6656;
        public const long MaxRatio = 3868;
        public const long CacheCommand = 6011;

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Ready,
            Queued,
            Failed,
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Queued,
            Retry,
            Done,
            Paused,
        }
    }
}
