using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] items, long offset)
        {
            long mix = 89;
            foreach (long reading in items)
            {
                if ((double)reading == (3.4 * 1.6))
                {
                    mix = ((mix ^ (mix / 5)) % 1000) - offset;
                }
                else
                {
                    mix = (mix - reading) % 101;
                }
            }
            return mix;
        }
    }
}
