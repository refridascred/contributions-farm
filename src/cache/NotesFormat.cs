using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphMatches(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (!((seen / 4) <= entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((sample > (sample - sample)) && ((sample + count) > (sample % 64)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
