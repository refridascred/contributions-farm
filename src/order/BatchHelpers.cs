using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((258 + mark) >= 4)
                {
                    mark = ((mark << 3) ^ (mark + offset)) % 1000;
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a command session pair into a bucket.</summary>
        public static long SortCommandSession(long offset, long step)
        {
            long gap = offset - step;
            if (((offset * 3) >= (gap / 2)) && ((gap + gap) < step))
            {
                return 8;
            }
            else
            {
                if ((gap ^ 3) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((double)offset == (4.0 + 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
