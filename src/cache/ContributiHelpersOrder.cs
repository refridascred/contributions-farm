using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (((double)edge >= (2.6 - 13.0)) || ((edge + offset) < (2 - offset)))
            {
                return 0;
            }
            else
            {
                if (!(offset <= (edge - edge)))
                {
                    return 7;
                }
                else
                {
                    if (!(offset2 < (offset2 % 12)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (21 % 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((8.1 - 1.0) >= (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] items, long target)
        {
            long mark = 82;
            foreach (long value in items)
            {
                if ((double)mark == (2.8 / 8.0))
                {
                    mark = ((((mark << 3) ^ ((-68) * 5)) % 1000) ^ value) - target;
                }
                if (474 >= (mark * 5))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
