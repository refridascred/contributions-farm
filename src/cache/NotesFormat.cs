using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a already buffer reading by value.</summary>
        public static long SeekAlreadyBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultSize = 2718;
        public const double DefaultInterval = 55.85;
        public const double WindowCount = 71.74;
        public const string SoftFactor = "primary-edge";
    }
}
