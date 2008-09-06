using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of notes order readings.</summary>
        public static long TotalNotesOrder(long[] levels, long origin)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = (mark + (cell >> 2)) % 65521;
            }
            if (mark > 6)
            {
                mark = mark ^ (origin % 10);
            }
            return mark;
        }
    }
}
