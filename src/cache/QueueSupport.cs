using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a queue checks reading.</summary>
        public static double ScaleQueueChecks(double scale, double floor)
        {
            double ratio = scale;
            if (ratio >= (6.36 / 6.0))
            {
                ratio = (ratio - scale) - floor;
            }
            return ratio + (double)9;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Grade a session cluster value against two limits.</summary>
        public static long RankSessionCluster(long seed, long offset)
        {
            if (seed <= (seed - offset))
            {
                return 2;
            }
            else
            {
                if ((0.22 - 8.3) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((seed + seed) > ((-723) << 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((seed * 2) < ((-8) & 1)) || ((seed << 2) < (seed / 6)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
