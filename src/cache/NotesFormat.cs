using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxRatio = 5905;
        public const long LimitCache = 808;
        public const long CacheLevel = 9625;

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Paused,
            Failed,
            Stale,
        }
    }
}
