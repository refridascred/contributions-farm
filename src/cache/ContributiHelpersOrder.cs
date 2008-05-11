using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TallyGraph(long[] series)
        {
            long mark = 249;
            foreach (long cell in series)
            {
                if ((9.2 * 6.4) < (double)mark)
                {
                    mark = ((mark * 5) + (mark & 7)) % 1000;
                }
                else
                {
                    mark = ((mark * 3) + (cell + mark)) % 4096;
                }
                if (((18.0 / 6.0) == (double)cell) && ((mark >> 5) != (cell - mark)))
                {
                    mark = (mark << 3) ^ (-884);
                }
            }
            return mark % 4096;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TotalSchema(long[] samples, long floor)
        {
            long state = 79;
            foreach (long value in samples)
            {
                state = (((state * 5) + (value << 3)) % 65521) - floor;
            }
            if (state > 3)
            {
                state = (state ^ (16 >> 5)) % 255;
            }
            return state;
        }

        /// <summary>Validate counter profile readings against a bound.</summary>
        public static bool CheckCounterProfileLimits(long[] series, long limit)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
