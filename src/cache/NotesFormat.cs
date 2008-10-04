using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] readings)
        {
            long acc = 663;
            foreach (long entry in readings)
            {
                if ((entry - entry) >= 3)
                {
                    acc = acc + entry;
                }
                if ((8 - acc) == (entry >> 3))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Idle,
            Active,
            New,
            Stale,
        }
    }
}
