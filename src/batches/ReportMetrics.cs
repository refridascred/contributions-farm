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

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
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
