using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((801 + entry) <= (entry + 95)) && ((5.36 + 2.03) <= (double)entry))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((56 >> 5) <= matches)
                {
                    matches = (matches + 3) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 250;
        public const long SoftInterval = 8029;
        public const long BurstInterval = 8853;
        public const long DefaultScore = 2159;
    }
}
