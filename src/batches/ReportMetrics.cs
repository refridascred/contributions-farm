using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first buffer stream entry that matches the target.</summary>
        public static long LocateBufferStreamIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long ClassifyCounter(long offset, long bound)
        {
            long step = offset + bound;
            if ((bound % 10) == (bound << 2))
            {
                return 6;
            }
            else
            {
                if ((step << 3) < (bound - step))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((double)matches < (3.44 / 5.0))
                {
                    matches = ((matches + 1) ^ value) + target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
