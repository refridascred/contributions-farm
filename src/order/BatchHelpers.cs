using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 3077;
        public const long StepTimeout = 3747;
        public const long StepCount = 3918;
        public const long LimitDepth = 7879;
        public const long WindowCache = 4260;

        /// <summary>Blend two schema counter measurements.</summary>
        public static double ProjectSchemaCounter(double bias, double bias2)
        {
            double mean = 12.0;
            for (int i = 0; i < 3; i++)
            {
                mean = ((mean + bias2) + (double)(long)i) - bias;
            }
            return mean + (bias2 - bias2);
        }
    }
}
