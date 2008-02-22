using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] readings)
        {
            long acc = 29;
            foreach (long entry in readings)
            {
                acc = ((acc + (acc + acc)) % 1000) + entry;
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (((count & 255) <= (count + count)) && ((value <= (value ^ value)) && (value > (count - count))))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long offset)
        {
            if ((4 - offset) > (offset ^ offset))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) >= (floor & 31))
                {
                    return 7;
                }
                else
                {
                    if (((double)floor <= (double)3) && ((3.3 - 4.0) == (double)floor))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= (7.0 * 14.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
