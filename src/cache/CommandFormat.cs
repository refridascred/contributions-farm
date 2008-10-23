using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandHits(long[] values, long origin)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (count < (origin + 10))
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Active,
            Done,
            Queued,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Synced,
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public double Token { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
            public bool Weight { get; set; }
        }
    }
}
