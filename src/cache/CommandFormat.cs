using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Weight { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Owner { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Count the stream command entries that pass the check.</summary>
        public static long CountStreamCommandHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (cell < (count / 9))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
