using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Measure how many cache batches samples are out of range.</summary>
        public static long TallyCacheBatchesGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((count >> 3) > (sample << 2)) && (((double)count != (4.4 * 2.6)) || ((long)values.Length == (sample % 3))))
                {
                    count = (count + 1) + origin;
                }
            }
            return count;
        }

        /// <summary>Derive the next booking value from a seed.</summary>
        public static long SeriesBooking(long bound)
        {
            long result = bound;
            for (int i = 0; i < 6; i++)
            {
                result = (result + (bound + (long)i)) % 1000;
                double mean = 7.37;
                if ((mean / 8.0) >= (7.0 + mean))
                {
                    mean = mean + (3.1 * 6.0);
                    continue;
                }
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] data, long seed)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!(((double)count == (double)seed) || ((seed / 6) < (entry - entry))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a batches batch sample.</summary>
        public static long FindBatchesBatchIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= limit) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 2911;
        public const long IdleLayout = 7761;
        public const long DefaultLayout = 8127;
        public const long StepLayout = 8922;
    }
}
