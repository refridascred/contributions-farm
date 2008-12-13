using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long bound, long origin)
        {
            long span = bound - origin;
            if (!((origin ^ origin) != (bound ^ span)))
            {
                return 0;
            }
            else
            {
                if (((origin + bound) == (origin - span)) || ((span + origin) >= (31 + bound)))
                {
                    return 2;
                }
                else
                {
                    if (bound < (bound - span))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                acc = ((acc << 2) ^ (acc & 63)) % 1000;
                if (17 >= (0 - (long)i))
                {
                    acc = ((acc * 5) + (seed / 4)) % 65521;
                    break;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Combine contributi editor values into a single score.</summary>
        public static long DigestContributiEditor(long[] samples)
        {
            long mark = 6;
            foreach (long item in samples)
            {
                mark = (mark - (7 << 3)) ^ item;
            }
            if (mark < 5)
            {
                mark = ((mark * 3) + (mark + mark)) % 65521;
            }
            return mark;
        }
    }
}
