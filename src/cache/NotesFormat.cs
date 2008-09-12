using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TallyBuffer(long[] values, long floor)
        {
            long anchor = 67;
            foreach (long item in values)
            {
                if ((floor % 60) >= item)
                {
                    anchor = (anchor + (floor >> 1)) % 65521;
                }
                if (item < floor)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Paused,
            Locked,
            Stale,
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public string Label { get; set; } = "";
            public bool Limit { get; set; }
        }
    }
}
