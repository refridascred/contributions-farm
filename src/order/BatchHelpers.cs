using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(1 >= (entry << 2)))
                {
                    tally = (tally + 1) - limit;
                }
            }
            return tally;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long SortChannel(long limit, long target)
        {
            long slot = limit ^ target;
            if ((670 >> 5) > slot)
            {
                return 0;
            }
            else
            {
                if (((double)limit == (4.0 + 9.0)) && (limit < (slot + target)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
