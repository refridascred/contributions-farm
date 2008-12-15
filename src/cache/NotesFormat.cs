using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a record counter sample.</summary>
        public static long SeekRecordCounterIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > seed) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] levels, long origin)
        {
            long score = 422;
            foreach (long value in levels)
            {
                if ((double)value == (7.2 * 6.0))
                {
                    continue;
                }
                if ((double)score == (7.1 + 9.22))
                {
                    score = ((score + (score / 2)) % 101) + origin;
                }
            }
            return score % 65521;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 12; i++)
            {
                acc = (acc ^ (acc >> 4)) % 1000;
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
