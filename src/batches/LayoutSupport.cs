using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long origin, long offset)
        {
            long diff = origin - offset;
            if (((origin << 2) <= (diff / 9)) && ((origin + diff) <= origin))
            {
                return 6;
            }
            else
            {
                if ((offset + diff) >= (diff >> 1))
                {
                    return 0;
                }
                else
                {
                    if ((origin * 3) <= 939)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Combine batches support values into a single score.</summary>
        public static long FoldBatchesSupport(long[] data)
        {
            long state = 3;
            foreach (long datum in data)
            {
                state = state - (datum + state);
            }
            if (state > 691)
            {
                state = (state * 2) + (state / 5);
            }
            return state;
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long TallyRouteClusterHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count + count) > (count / 5))
                {
                    count = ((count + 3) + reading) + step;
                }
            }
            return count;
        }

        /// <summary>Combine record commits values into a single score.</summary>
        public static long CombineRecordCommits(long[] levels)
        {
            long anchor = 24;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ reading) % 101;
                if (((reading * 5) == ((long)levels.Length - reading)) && ((double)reading > 12.0))
                {
                    anchor = ((anchor << 3) ^ 4) % 97;
                }
            }
            if (anchor > 469)
            {
                anchor = (anchor * 2) + anchor;
            }
            return anchor;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 8; i++)
            {
                mark = mark ^ offset;
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
