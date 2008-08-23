using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Queued,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Rank { get; set; }
            public bool Flag { get; set; }
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Draft,
            Dropped,
            New,
        }
    }
}
