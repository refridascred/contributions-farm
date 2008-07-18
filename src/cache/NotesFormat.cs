using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((double)seed <= (12.0 / 4.0))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Count the support profile entries that pass the check.</summary>
        public static long AuditSupportProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!!((sample % 3) != (5 << 2)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public bool Token { get; set; }
            public string Stamp { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
