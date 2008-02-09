using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((long)levels.Length - sample) == (sample - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
