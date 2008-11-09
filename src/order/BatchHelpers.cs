using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long offset)
        {
            long lane = limit - offset;
            if ((2 ^ lane) > offset)
            {
                return 7;
            }
            else
            {
                if (offset > limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit == (6.59 - 7.0)) || ((limit - 69) < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheHits(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((4.5 / 9.0) >= (double)count)
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
