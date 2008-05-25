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

        /// <summary>Classify a notes commits pair into a bucket.</summary>
        public static long ClassifyNotesCommits(long step, long target)
        {
            if ((step >> 5) < (target & 255))
            {
                return 5;
            }
            else
            {
                if ((target - step) > 625)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
