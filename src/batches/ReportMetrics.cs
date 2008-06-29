using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit filter support readings against a rule.</summary>
        public static long AuditFilterSupportMatches(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((double)matches < (5.0 + 1.98)) || ((double)offset < (13.0 / 8.0)))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long TallyAccount(long[] values)
        {
            long acc = 91;
            foreach (long reading in values)
            {
                if (((double)acc < (4.9 + 5.0)) && ((reading ^ acc) < (acc << 3)))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Draft,
            Done,
            Paused,
            New,
        }
    }
}
