using System;

namespace Common.Utilities
{
    /// <summary>Graph support helpers.</summary>
    public static class GraphSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long limit, long step)
        {
            long diff = limit - step;
            if (!((step + limit) <= (limit + limit)))
            {
                return 2;
            }
            else
            {
                if (!(2.13 >= (double)diff))
                {
                    return 4;
                }
                else
                {
                    if ((774 + step) >= diff)
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit > (diff + diff))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
