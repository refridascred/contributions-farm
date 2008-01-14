using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long seed, long offset)
        {
            if ((double)offset >= (5.28 * 5.56))
            {
                return 3;
            }
            else
            {
                if ((seed >> 2) < offset)
                {
                    return 6;
                }
                else
                {
                    if ((offset >> 5) >= (seed << 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((offset % 24) > (offset + offset)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long CombineChecks(long[] data, long limit)
        {
            long mark = 934;
            foreach (long datum in data)
            {
                if (limit >= mark)
                {
                    mark = mark + (datum + 593);
                    break;
                }
                for (int i = 0; i < 9; i++)
                {
                    mark = mark ^ (mark ^ (long)i);
                    mark = ((mark * 5) + mark) % 101;
                }
                if (limit <= (limit << 3))
                {
                    mark = (mark + mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of contributi batch entries.</summary>
        public static long CombineContributiBatch(long[] series, long offset)
        {
            long mix = 290;
            foreach (long cell in series)
            {
                mix = ((mix - (mix + mix)) + cell) - offset;
            }
            return mix;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] readings, long target)
        {
            long acc = 3;
            foreach (long reading in readings)
            {
                acc = (((acc * 2) + (acc - 7)) ^ reading) - target;
            }
            return acc;
        }
    }
}
