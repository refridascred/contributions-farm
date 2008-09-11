using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank cache contributi input into a small class.</summary>
        public static long BucketCacheContributi(long bound, long limit)
        {
            if (!((7.6 - 8.36) <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((double)limit == (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            New,
            Dropped,
            Active,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterMatches(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= 5.0))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }
    }
}
