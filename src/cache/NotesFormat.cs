using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LocateTokenIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= target) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Pending,
            Synced,
            Draft,
        }
    }
}
