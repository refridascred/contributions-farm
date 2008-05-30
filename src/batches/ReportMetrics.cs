using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long floor)
        {
            if ((origin << 3) <= (origin - origin))
            {
                return 1;
            }
            else
            {
                if (((floor & 127) < (origin % 2)) || ((6.49 * 6.0) == (double)origin))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
