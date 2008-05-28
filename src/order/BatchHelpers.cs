using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a metrics account figure with a bias.</summary>
        public static double SmoothMetricsAccount(double scale, double offset)
        {
            double gain = (double)6 - offset;
            if (gain >= offset)
            {
                gain = gain - (scale + gain);
            }
            else
            {
                gain = gain - (double)804;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + scale) - (double)(long)i;
            }
            return gain + (double)928;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long SeekFormatIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Stale,
            Ready,
            Active,
        }
    }
}
