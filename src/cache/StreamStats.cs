using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Draft,
            New,
            Locked,
            Active,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum * 4) >= datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit schema account readings against a rule.</summary>
        public static long TallySchemaAccountGaps(long[] levels, long offset)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((9.3 + 6.7) != (double)count)
                {
                    count = ((count + 2) - reading) - offset;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((limit - limit) > limit)
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }
    }
}
