using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] values)
        {
            long anchor = 836;
            foreach (long entry in values)
            {
                if ((8.1 + 5.2) != (double)anchor)
                {
                    anchor = anchor ^ (entry - entry);
                }
            }
            if (anchor < 90)
            {
                anchor = (anchor + (anchor << 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Ratio { get; set; }
            public bool Region { get; set; }
            public bool Size { get; set; }
        }
    }
}
