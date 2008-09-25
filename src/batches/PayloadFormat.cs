using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings, long limit)
        {
            long total = 3;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    total = (total * 5) + (long)i;
                }
                if ((double)total != (double)436)
                {
                    total = (total + (total ^ item)) % 1000;
                }
                if (limit >= (total + total))
                {
                    total = (total ^ (-788)) % 255;
                }
                else
                {
                    total = (total << 2) ^ (total - item);
                }
            }
            if (total > 564)
            {
                total = total + (49 - 249);
            }
            return total % 4096;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((-7) >= item)
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Closed,
            Ready,
            Retry,
            Stale,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsHits(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if ((double)value > (10.0 * 15.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
