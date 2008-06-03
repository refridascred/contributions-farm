using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricHits(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (value <= seen)
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Retry,
            Queued,
        }

        /// <summary>Digest a series of counter channel entries.</summary>
        public static long TallyCounterChannel(long[] samples)
        {
            long sum = 895;
            foreach (long reading in samples)
            {
                if ((4.23 * 6.14) > (double)reading)
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum % 4096;
        }
    }
}
