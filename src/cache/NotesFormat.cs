using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Stamp { get; set; }
            public long Region { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Draft,
            Closed,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultCommand = 8743;
        public const long MaxBudget = 1439;
        public const long CacheCount = 4692;
    }
}
