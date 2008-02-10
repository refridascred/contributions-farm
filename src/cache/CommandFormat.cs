using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first command batches entry that matches the target.</summary>
        public static long SeekCommandBatchesIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a entry cluster reading.</summary>
        public static double AdjustEntryCluster(double weight, double span)
        {
            double scale = span;
            if (scale < (7.3 - weight))
            {
                scale = scale + scale;
            }
            return scale - 2.04;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long result = 464;
            foreach (long reading in items)
            {
                if (!(reading < offset))
                {
                    result = (result - 66) % 101;
                }
                else
                {
                    result = (result * 5) + (offset - reading);
                }
            }
            return result;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double bias, double offset)
        {
            double load = offset - (bias + bias);
            if (load > load)
            {
                load = load - 2.0;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + offset) + (double)(long)i;
            }
            return load + (bias * 9.99);
        }
    }
}
