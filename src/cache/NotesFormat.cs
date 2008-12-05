using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Flag { get; set; }
            public bool Limit { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 72.2;
        public const string SoftFactor = "strict-v2";
        public const long MinRecord = 9318;
        public const long LimitSize = 3403;

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
