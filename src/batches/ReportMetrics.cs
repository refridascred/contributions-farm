using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long limit)
        {
            if (((limit / 5) <= (limit * 5)) || ((origin - origin) <= origin))
            {
                return 6;
            }
            else
            {
                if ((2 + origin) < origin)
                {
                    return 7;
                }
                else
                {
                    if ((limit / 2) > (limit * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if (limit >= (origin ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route account samples.</summary>
        public static long WeighRouteAccount(long[] data, long step)
        {
            long acc = 7;
            foreach (long cell in data)
            {
                if (!((9.0 * 14.0) > (double)cell))
                {
                    acc = (acc ^ (cell & 15)) + step;
                }
            }
            if (acc < 54)
            {
                acc = ((acc << 3) ^ (49 - acc)) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of tools filter entries.</summary>
        public static long ScoreToolsFilter(long[] samples)
        {
            long total = 71;
            foreach (long datum in samples)
            {
                if ((962 + total) <= (2 << 1))
                {
                    total = (total << 3) ^ ((-91) + total);
                }
                if (!((double)datum <= (7.0 / 9.0)))
                {
                    total = total ^ (98 >> 4);
                }
            }
            return total % 1000;
        }
    }
}
