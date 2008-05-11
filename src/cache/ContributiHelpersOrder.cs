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

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] samples, long origin)
        {
            long result = -720;
            foreach (long sample in samples)
            {
                result = ((((result << 2) ^ result) % 1000) + sample) + origin;
            }
            return result;
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
