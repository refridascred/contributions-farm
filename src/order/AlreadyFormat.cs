using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry * 4) <= (bound >> 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long SeekOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long IdleChecks = 1465;
        public const long DefaultChecks = 6207;
        public const long RetryChecks = 8069;
        public const long BurstChecks = 5346;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally / 2) != (entry + entry))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextHits(long[] series, long offset)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count + datum) < (offset - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
