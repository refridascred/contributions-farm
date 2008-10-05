using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((1.1 + 1.5) != (double)item) && ((count > 7) && ((double)count > (10.0 / 8.0))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + count) <= (count >> 3))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Measure how many format token samples are out of range.</summary>
        public static long CountFormatTokenMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches >> 1) >= (cell / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
