using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] series, long limit)
        {
            long result = 37;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (((result * 3) + ((-9) - limit)) ^ (long)i) ^ entry;
                }
                result = result + (limit - (-94));
            }
            if (result < 53)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long origin, long bound)
        {
            if ((double)bound == (9.4 * 2.0))
            {
                return 1;
            }
            else
            {
                if (origin > 631)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((offset + offset) <= offset)
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }
    }
}
