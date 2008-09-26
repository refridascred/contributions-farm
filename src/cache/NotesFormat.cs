using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseDepth = 1760;
        public const string MinInterval = "stable-edge";
        public const long BurstBudget = 9035;
        public const long DefaultSpan = 5601;

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Locked,
            Pending,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 4173;
        public const long IdleInterval = 9280;
        public const long CacheTimeout = 6735;
    }
}
