using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample + 44) < (sample ^ bound))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardLevel = 1877;
        public const long BatchCount = 5887;
        public const long MaxWidth = 4827;
        public const double BaseReport = 10.54;

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally << 1) <= (entry >> 2))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
