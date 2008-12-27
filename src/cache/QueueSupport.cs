using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((3 >= cell) || !((cell + 42) > seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((5.1 + 6.67) <= (double)origin)
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
