using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long SeekChannelIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long limit, long target)
        {
            if (!((target / 6) <= (limit + 118)))
            {
                return 5;
            }
            else
            {
                if (((target * 5) >= (target + target)) && ((limit >> 1) == (38 + limit)))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
