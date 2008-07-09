using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long BucketNotes(long bound, long limit)
        {
            long span = bound + limit;
            if (59 <= (limit & 63))
            {
                return 4;
            }
            else
            {
                if ((double)22 != (double)span)
                {
                    return 5;
                }
                else
                {
                    if (!((56 - 80) > (limit - span)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
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
