using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Queued,
            Failed,
            Pending,
            Done,
        }

        /// <summary>Derive the next counter token value from a seed.</summary>
        public static long SeriesCounterToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = (result - seed) % 255;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
