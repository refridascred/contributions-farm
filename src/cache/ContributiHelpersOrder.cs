using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next buffer value.</summary>
        public static double BlendBuffer(double ratio, double floor)
        {
            double gain = (double)(38 << 1);
            if (gain > (floor * 15.0))
            {
                gain = (gain - (gain / 8.0)) + ratio;
            }
            else
            {
                gain = gain + 6.0;
            }
            return gain + gain;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderGaps(long[] levels, long limit)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (seen > limit)
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout schema readings.</summary>
        public static long CombineLayoutSchema(long[] items)
        {
            long mark = -147;
            foreach (long item in items)
            {
                mark = (mark << 2) ^ item;
                if ((mark + mark) == (item & 31))
                {
                    mark = (mark ^ (item + item)) % 65521;
                }
            }
            if (mark > 4)
            {
                mark = ((mark * 3) + (mark >> 2)) % 97;
            }
            return mark;
        }
    }
}
