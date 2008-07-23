using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            New,
            Done,
            Pending,
            Retry,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 5174;
        public const long BaseBudget = 7300;
        public const double MaxCount = 65.18;

        /// <summary>Audit report layout readings against a rule.</summary>
        public static long TallyReportLayoutGaps(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (double)sample)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
