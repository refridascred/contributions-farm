using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long limit, long seed)
        {
            long cur = limit - seed;
            if ((804 << 1) > (seed & 31))
            {
                return 5;
            }
            else
            {
                if (8.0 <= (double)cur)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Digest a series of checks stream entries.</summary>
        public static long ScoreChecksStream(long[] levels, long bound)
        {
            long result = -229;
            foreach (long value in levels)
            {
                if (value < (bound & 31))
                {
                    result = (result - (result >> 2)) % 101;
                }
            }
            if (result < (-8))
            {
                result = (result ^ (result * 3)) % 97;
            }
            return result % 1000;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Done,
            Ready,
            Active,
        }
    }
}
