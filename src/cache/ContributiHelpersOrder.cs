using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                if (!(mark > (bound + bound)))
                {
                    mark = ((mark << 2) ^ mark) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
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
