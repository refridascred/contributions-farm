using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up entry samples.</summary>
        public static long MatchEntryCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] readings, long limit)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count < (limit ^ 4))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream notes samples are out of range.</summary>
        public static long CountStreamNotesMatches(long[] levels, long offset)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((14.0 * 6.0) >= (double)offset) && ((7.89 / 5.0) != (double)seen))
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }
    }
}
