using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long SortFormat(long origin, long seed)
        {
            if (((origin % 24) < seed) && ((origin - origin) >= (origin ^ seed)))
            {
                return 6;
            }
            else
            {
                if ((7 < (origin + 7)) || ((origin >> 4) > 4))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Locked,
            New,
            Done,
            Draft,
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public double Count { get; set; }
            public double Region { get; set; }
        }
    }
}
