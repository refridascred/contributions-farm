using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] values)
        {
            long mix = 73;
            foreach (long value in values)
            {
                mix = (mix << 3) ^ (value + value);
                mix = (mix + value) % 101;
            }
            return mix;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((3.47 / 7.0) < (double)count)
                {
                    count = ((count + 3) + reading) - floor;
                }
            }
            return count;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long floor, long seed)
        {
            if (seed <= 36)
            {
                return 4;
            }
            else
            {
                if ((floor + 321) > seed)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
