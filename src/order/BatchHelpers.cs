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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (4.6 + 7.98))
                {
                    count = count + 1;
                }
            }
            return count;
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
