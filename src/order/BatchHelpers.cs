using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamRange(long[] samples, long origin)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long MeasureMetricEditorOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (seed > (item + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank stats profile input into a small class.</summary>
        public static long SortStatsProfile(long target, long limit)
        {
            long diff = target ^ limit;
            if ((target & 3) != (9 + limit))
            {
                return 3;
            }
            else
            {
                if ((diff & 1) >= (limit + diff))
                {
                    return 8;
                }
                else
                {
                    if (((6.1 + 5.3) < (double)diff) && (limit <= (diff & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
