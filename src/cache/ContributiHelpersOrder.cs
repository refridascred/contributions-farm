using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long offset)
        {
            long slot = seed ^ offset;
            if (seed < (seed / 3))
            {
                return 4;
            }
            else
            {
                if ((double)seed > (double)slot)
                {
                    return 6;
                }
                else
                {
                    if ((1 << 3) <= seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((seed - 888) != (offset << 2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (offset > (count + offset))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((value - hits) == (hits % 2))
                {
                    hits = (hits + 3) - offset;
                }
            }
            return hits;
        }
    }
}
