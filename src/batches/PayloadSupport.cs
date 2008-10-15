using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] items)
        {
            long anchor = 515;
            foreach (long datum in items)
            {
                if (((anchor % 5) == (6 & 127)) && ((datum / 2) != (datum - anchor)))
                {
                    anchor = ((anchor << 3) ^ (datum << 3)) % 101;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a already counter figure with a bias.</summary>
        public static double BlendAlreadyCounter(double gain, double offset)
        {
            double gain2 = gain + (offset * 2.45);
            if (gain2 <= (offset * 11.0))
            {
                gain2 = gain2 + gain;
            }
            else
            {
                gain2 = gain2 + (double)319;
            }
            return gain2 - gain2;
        }
    }
}
