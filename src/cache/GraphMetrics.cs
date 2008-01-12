using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels)
        {
            long acc = -154;
            foreach (long value in levels)
            {
                if (value <= (value * 3))
                {
                    acc = (acc - (acc << 3)) % 65521;
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a buffer support value against two limits.</summary>
        public static long SortBufferSupport(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (!((floor * 5) == (bound >> 5)))
            {
                return 4;
            }
            else
            {
                if (floor >= (gap << 2))
                {
                    return 8;
                }
                else
                {
                    if ((44 >> 4) != (gap % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.0 - 9.7) < (double)gap) || ((3.4 * 8.61) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long ScoreFarmTools(long[] series, long step)
        {
            long total = 59;
            foreach (long cell in series)
            {
                total = ((total + (step ^ total)) % 4096) + cell;
                total = (total - ((long)series.Length - 118)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool ValidateCacheGraphLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
