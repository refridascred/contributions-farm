using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Active,
            Locked,
            Idle,
            Ready,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Active,
            Pending,
            Retry,
        }
    }
}
