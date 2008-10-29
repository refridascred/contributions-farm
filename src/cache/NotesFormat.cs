using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next queue buffer value from a seed.</summary>
        public static long DeriveQueueBuffer(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                double scale = (double)3;
                if ((double)origin <= scale)
                {
                    carry = (carry + carry) % 255;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many schema commits samples are out of range.</summary>
        public static long MeasureSchemaCommitsOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry < (19.0 - 16.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueHits(long[] data, long seed)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches % 2) >= (item + seed))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
