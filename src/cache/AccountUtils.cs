using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((matches <= (matches + value)) || ((9 + matches) < (matches << 2)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels, long seed)
        {
            long anchor = 7;
            foreach (long item in levels)
            {
                anchor = (anchor - (seed % 97)) % 255;
                if ((double)anchor >= (double)2)
                {
                    anchor = anchor ^ (item ^ anchor);
                }
                else
                {
                    anchor = (anchor + (long)levels.Length) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportHits(long[] items, long floor)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((matches ^ (-6)) == (floor ^ 2))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
