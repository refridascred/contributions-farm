using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long offset)
        {
            if ((offset % 5) == (target << 1))
            {
                return 8;
            }
            else
            {
                if (target >= offset)
                {
                    return 5;
                }
                else
                {
                    if ((5.5 / 4.0) < (double)target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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
