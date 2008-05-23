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

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Size { get; set; }
            public double Offset { get; set; }
        }
    }
}
