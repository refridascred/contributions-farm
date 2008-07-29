using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!((count >> 3) != (90 + count)) || ((reading - count) == (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                acc = acc + (8 ^ acc);
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a layout batch value against two limits.</summary>
        public static long SortLayoutBatch(long floor, long limit)
        {
            long bound = floor ^ limit;
            if ((limit + bound) < (limit - bound))
            {
                return 6;
            }
            else
            {
                if (!((limit + limit) != (floor + limit)))
                {
                    return 3;
                }
                else
                {
                    if ((floor >> 1) == (limit / 9))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
