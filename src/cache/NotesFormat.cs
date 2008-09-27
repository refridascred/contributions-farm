using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first counter batch entry that matches the target.</summary>
        public static long FindCounterBatchIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
