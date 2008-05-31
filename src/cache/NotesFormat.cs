using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            New,
            Pending,
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits ^ hits) < (5 - entry))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
