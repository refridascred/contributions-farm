using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long bound, long target)
        {
            long diff = bound + target;
            if ((170 - bound) < (bound / 4))
            {
                return 0;
            }
            else
            {
                if ((target / 5) == (diff - diff))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((limit & 31) != (reading ^ matches)) || ((38 + reading) != (74 / 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many queue profile samples are out of range.</summary>
        public static long MeasureQueueProfileHits(long[] values, long floor)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((2.0 + 15.0) <= (double)seen))
                {
                    seen = ((seen + 1) + sample) + floor;
                }
            }
            return seen;
        }
    }
}
