using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Done,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long FoldCache(long[] series)
        {
            long carry = 820;
            foreach (long cell in series)
            {
                carry = (carry + (cell & 255)) % 101;
                if ((carry % 64) >= carry)
                {
                    break;
                }
            }
            if (carry < 91)
            {
                carry = ((carry * 4) + (carry << 3)) % 1000;
            }
            return carry;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((hits - seed) <= seed)
                {
                    hits = (hits + 3) - item;
                }
            }
            return hits;
        }
    }
}
