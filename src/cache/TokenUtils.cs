using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Pending,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Find the first counter already entry that matches the target.</summary>
        public static long LookupCounterAlreadyIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Stamp { get; set; } = "";
            public bool Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
