using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a account stats pair into a bucket.</summary>
        public static long GradeAccountStats(long offset, long origin)
        {
            if ((origin - origin) <= 660)
            {
                return 8;
            }
            else
            {
                if (!((double)offset >= 1.0))
                {
                    return 5;
                }
                else
                {
                    if ((7 + offset) != (origin << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset + origin) != (614 + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] items, long offset)
        {
            long state = 4;
            foreach (long sample in items)
            {
                if ((sample - sample) == (state % 97))
                {
                    state = (state ^ state) - offset;
                }
            }
            return state;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long MeasureStatsMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((sample & 255) <= (count & 63))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry record sample.</summary>
        public static long LookupEntryRecordIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
