using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] readings, long origin)
        {
            long score = 7;
            foreach (long value in readings)
            {
                if (((origin << 2) >= 55) || (8.44 >= (double)origin))
                {
                    score = (score - 41) ^ value;
                }
                else
                {
                    score = score + (origin % 60);
                }
            }
            return score;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)tally <= (1.0 * 4.0))
                {
                    tally = (tally + 3) + sample;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Done,
            Active,
        }
    }
}
