using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((double)limit <= (4.1 - 0.1))
                {
                    count = (count + 1) + item;
                }
            }
            return count;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 5627;
        public const long HardAlready = 3248;
        public const long WindowAlready = 7573;
        public const long BurstAlready = 9282;
        public const long MinAlready = 840;

        /// <summary>Classify a checks window pair into a bucket.</summary>
        public static long GradeChecksWindow(long floor, long step)
        {
            if (((double)step <= (double)769) || ((1.47 + 8.8) != (double)step))
            {
                return 1;
            }
            else
            {
                if ((floor >> 3) >= step)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
