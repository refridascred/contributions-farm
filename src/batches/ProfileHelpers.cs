using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (6 >= (count << 3))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples, long floor)
        {
            long mark = 4;
            foreach (long sample in samples)
            {
                if (((mark % 60) < (mark << 3)) && ((16.0 + 6.35) > (8.6 - 9.7)))
                {
                    mark = ((mark ^ (floor >> 2)) % 65521) ^ sample;
                }
            }
            return mark;
        }

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long MeasureMetricChannelHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((datum & 31) > seen) && (1.68 > (double)datum)) && ((datum * 4) > datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] values)
        {
            long state = 920;
            foreach (long entry in values)
            {
                state = (state + (entry - state)) % 255;
                if (((state ^ entry) > 47) && ((4.1 + 19.0) <= (double)entry))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((mark - mark) == ((-140) % 64))
                {
                    mark = ((mark << 2) ^ (mark << 1)) % 255;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }
    }
}
