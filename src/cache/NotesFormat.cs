using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches >> 1) > matches)
                {
                    matches = ((matches + 3) + cell) - seed;
                }
            }
            return matches;
        }

        /// <summary>Rank token schema input into a small class.</summary>
        public static long SortTokenSchema(long limit, long floor)
        {
            long edge = limit + floor;
            if ((floor * 2) == (limit % 97))
            {
                return 2;
            }
            else
            {
                if ((59 - (-88)) > floor)
                {
                    return 0;
                }
                else
                {
                    if ((8.0 + 4.55) < (double)edge)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor - floor) < limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 7333;
        public const long MaxSupport = 6301;
        public const long HardSupport = 4370;
        public const string SoftSize = "cached-1";
    }
}
