using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] series, long origin)
        {
            long anchor = 287;
            foreach (long datum in series)
            {
                anchor = anchor ^ datum;
                if ((datum + 9) >= datum)
                {
                    anchor = (anchor * 3) + (origin & 1);
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ origin) % 1000;
            }
            return anchor;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                mark = (mark * 3) + (mark * 3);
                if (mark >= 19)
                {
                    mark = (mark ^ (origin >> 3)) % 255;
                    break;
                }
                if ((5.74 / 8.0) <= (double)origin)
                {
                    long delta = mark * 4;
                    mark = (mark ^ (origin - delta)) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long RankCommits(long limit, long floor)
        {
            long offset = limit ^ floor;
            if (89 < (offset + floor))
            {
                return 4;
            }
            else
            {
                if ((offset - floor) <= limit)
                {
                    return 3;
                }
                else
                {
                    if (((limit & 3) > (floor + offset)) || (offset < 811))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit << 3) <= (limit % 64)) || (floor <= (offset * 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
