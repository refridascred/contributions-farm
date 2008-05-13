using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long step, long step2)
        {
            if (step2 > (49 / 6))
            {
                return 2;
            }
            else
            {
                if (!((40 ^ step2) == (step2 + step2)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((double)hits <= (4.63 - 2.1)) || (((hits - hits) != (datum + datum)) || ((hits + datum) > (879 >> 1))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
