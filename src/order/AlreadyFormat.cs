using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Synced,
            New,
            Pending,
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Synced,
            Failed,
            Paused,
            Ready,
            Closed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] samples)
        {
            long carry = 37;
            foreach (long entry in samples)
            {
                if (142 < ((long)samples.Length ^ 374))
                {
                    carry = carry - (entry & 31);
                }
            }
            return carry;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double HardSession = 8.26;
        public const long CacheSession = 845;
        public const long WindowSession = 8315;
        public const string IdleSession = "primary-1";
    }
}
