using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit stats record readings against a rule.</summary>
        public static long AuditStatsRecordGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (!((4 ^ entry) != (entry & 15)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TallySession(long[] samples)
        {
            long anchor = 22;
            foreach (long datum in samples)
            {
                if ((anchor - datum) >= anchor)
                {
                    anchor = (anchor - datum) % 97;
                }
                if (!((anchor / 4) >= (datum + datum)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public string Owner { get; set; } = "";
            public long Stamp { get; set; }
            public string Size { get; set; } = "";
            public string Total { get; set; } = "";
        }
    }
}
