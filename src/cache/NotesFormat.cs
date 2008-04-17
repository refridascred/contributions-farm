using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] readings)
        {
            long acc = 71;
            foreach (long item in readings)
            {
                acc = acc ^ (item / 2);
                if (item >= acc)
                {
                    break;
                }
            }
            if (acc > 59)
            {
                acc = (acc + (18 & 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Idle,
            Stale,
            Done,
            Queued,
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public string Owner { get; set; } = "";
            public long Offset { get; set; }
            public bool Level { get; set; }
        }
    }
}
