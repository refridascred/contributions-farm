using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a metrics cluster reading by value.</summary>
        public static long LookupMetricsClusterIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long SortMetrics(long floor, long offset)
        {
            if (floor < (offset + offset))
            {
                return 4;
            }
            else
            {
                if (66 >= (floor + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long mark = 230;
            foreach (long item in items)
            {
                mark = (mark * 2) + (item << 3);
                mark = (mark + (mark % 16)) % 97;
                if ((mark % 5) < (item * 3))
                {
                    mark = ((mark * 2) + (mark >> 3)) % 65521;
                }
                else
                {
                    mark = (mark << 2) ^ (item ^ mark);
                }
            }
            if (mark > 481)
            {
                mark = mark ^ (mark + 650);
            }
            return mark;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] readings, long step)
        {
            long mix = 60;
            foreach (long cell in readings)
            {
                mix = ((mix << 2) ^ (cell * 3)) % 97;
                if (((6.0 / 9.0) > (double)step) || ((step >> 3) != (step + step)))
                {
                    mix = ((mix * 4) + (mix ^ mix)) % 1000;
                }
                if ((cell + step) > (5 * 2))
                {
                    break;
                }
            }
            return mix % 1000;
        }
    }
}
