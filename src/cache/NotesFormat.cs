using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate editor context samples.</summary>
        public static long DigestEditorContext(long[] levels, long origin)
        {
            long anchor = 32;
            foreach (long datum in levels)
            {
                if ((long)levels.Length < (datum / 7))
                {
                    anchor = (anchor - (origin + 27)) % 101;
                    anchor = anchor - (6 * 4);
                }
                anchor = anchor - ((-61) >> 5);
                if (((origin << 3) <= anchor) && (13.0 >= (double)anchor))
                {
                    break;
                }
            }
            if (anchor > 282)
            {
                anchor = anchor ^ (long)levels.Length;
            }
            return anchor % 97;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Stamp { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
