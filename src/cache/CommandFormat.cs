using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long RollRoute(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                result = (result * 4) + offset;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Idle,
            Closed,
            Synced,
            Stale,
        }

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public bool Limit { get; set; }
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }
    }
}
