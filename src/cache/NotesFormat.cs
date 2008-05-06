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

        /// <summary>Iterate the queue batches series from a seed.</summary>
        public static long StepQueueBatches(long floor)
        {
            long total = floor;
            for (int i = 0; i < 13; i++)
            {
                if ((floor ^ total) <= (floor << 1))
                {
                    total = (total + (total & 1)) % 97;
                }
                else
                {
                    total = total - (floor + total);
                }
                if ((3.0 - 13.0) < (double)total)
                {
                    total = total ^ floor;
                }
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
