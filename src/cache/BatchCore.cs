using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] levels)
        {
            long anchor = 41;
            foreach (long sample in levels)
            {
                if (8.2 > (double)sample)
                {
                    anchor = ((anchor * 2) + (anchor + sample)) % 97;
                }
            }
            if (anchor > 63)
            {
                anchor = (anchor << 3) ^ (anchor - 3);
            }
            return anchor % 1000;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cache queue value from a seed.</summary>
        public static long StepCacheQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 18; i++)
            {
                total = (total << 2) ^ (total >> 5);
                total = (total ^ limit) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long LocateMetricIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
