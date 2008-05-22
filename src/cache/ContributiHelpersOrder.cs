using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate buffer farm samples.</summary>
        public static long FoldBufferFarm(long[] levels)
        {
            long mark = 13;
            foreach (long reading in levels)
            {
                if (!(mark >= (mark + reading)))
                {
                    mark = ((mark << 3) ^ (mark - reading)) % 97;
                }
                if ((4.1 - 9.59) > (double)reading)
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LocateCacheIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long TallySchemaQueueGaps(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((double)seen >= (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
