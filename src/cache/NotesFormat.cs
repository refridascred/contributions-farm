using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit order checks readings against a rule.</summary>
        public static long MeasureOrderChecksHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((0.78 - 1.0) >= (double)(long)data.Length)
                {
                    matches = ((matches + 1) + value) + limit;
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi filter samples.</summary>
        public static long CombineContributiFilter(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit & 1)) % 97) - datum;
            }
            return anchor % 1000;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] items, long offset)
        {
            long score = -816;
            foreach (long reading in items)
            {
                score = (score << 2) ^ (reading + offset);
            }
            return score;
        }
    }
}
