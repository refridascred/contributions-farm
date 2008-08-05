using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = span;
            if (weight <= (span / 9.0))
            {
                weight = (weight - weight) - bias;
            }
            else
            {
                weight = weight + (double)30;
            }
            return weight + (0.2 * 5.3);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] items, long origin)
        {
            long mix = 37;
            foreach (long cell in items)
            {
                if ((double)2 == (double)mix)
                {
                    mix = ((mix + cell) % 65521) - origin;
                }
            }
            if (mix > 3)
            {
                mix = mix + (mix << 3);
            }
            return mix % 97;
        }
    }
}
