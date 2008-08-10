using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a farm filter pair into a bucket.</summary>
        public static long SortFarmFilter(long seed, long bound)
        {
            long next = seed + bound;
            if (bound < (next % 5))
            {
                return 1;
            }
            else
            {
                if ((double)bound >= 3.76)
                {
                    return 5;
                }
                else
                {
                    if ((2.94 * 8.0) < (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)bound > 6.16) || ((5.1 + 5.44) >= (double)seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                mix = (mix ^ (target >> 2)) % 101;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] items)
        {
            long mark = 69;
            foreach (long entry in items)
            {
                if (((long)items.Length + entry) < (entry & 127))
                {
                    mark = (mark << 2) ^ ((-889) + 62);
                }
            }
            if (mark < 649)
            {
                mark = mark ^ (mark / 3);
            }
            return mark;
        }
    }
}
