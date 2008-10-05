using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public double Level { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (entry < count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many window entry samples are out of range.</summary>
        public static long CountWindowEntryGaps(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (item >= (matches - matches))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
