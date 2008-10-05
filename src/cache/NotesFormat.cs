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

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] samples)
        {
            long mix = 59;
            foreach (long value in samples)
            {
                mix = ((mix * 3) + (value + value)) % 1000;
                if ((double)value <= (5.74 + 3.65))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
