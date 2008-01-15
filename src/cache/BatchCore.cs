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

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] data, long floor)
        {
            long mark = 50;
            foreach (long value in data)
            {
                if ((value / 5) >= ((-37) % 64))
                {
                    mark = (mark + (floor * 5)) % 65521;
                }
            }
            return mark % 4096;
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
