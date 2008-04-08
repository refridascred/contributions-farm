using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] levels)
        {
            long mix = 24;
            foreach (long value in levels)
            {
                if ((mix ^ 99) <= (mix + mix))
                {
                    mix = (mix * 3) + (67 >> 2);
                }
                if ((value * 2) != (mix ^ mix))
                {
                    break;
                }
            }
            return mix % 1000;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + tally) == (tally / 2))
                {
                    tally = (tally + 2) + offset;
                }
            }
            return tally;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value >= (value ^ matches)) && ((value - value) <= matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
