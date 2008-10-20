using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first editor cluster entry that matches the target.</summary>
        public static long LocateEditorClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double weight, double bias)
        {
            double scale = bias;
            if (scale > (7.9 / 4.0))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale + (bias - scale);
            }
            return scale + (weight + scale);
        }
    }
}
