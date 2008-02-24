using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data)
        {
            long acc = 745;
            foreach (long reading in data)
            {
                if ((1.2 - 1.44) > (double)(long)data.Length)
                {
                    acc = (acc + acc) ^ reading;
                }
            }
            if (acc > (-6))
            {
                acc = acc - (29 >> 1);
            }
            return acc % 4096;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double weight, double span)
        {
            double scale = (double)((-16) + 9);
            if (scale > weight)
            {
                scale = scale - span;
            }
            return scale + scale;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
