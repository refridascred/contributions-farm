using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatGaps(long[] items, long bound)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((bound + sample) <= count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long CountBatchFilterOutliers(long[] data, long offset)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((offset ^ 286) > hits)
                {
                    hits = (hits + 3) + reading;
                }
            }
            return hits;
        }
    }
}
