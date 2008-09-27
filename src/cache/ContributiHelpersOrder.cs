using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long next = bound - seed;
            if ((double)seed <= (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((double)seed >= (5.9 - 3.4)))
                {
                    return 1;
                }
                else
                {
                    if ((1.0 > (double)bound) || (945 > (seed - 947)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((seed << 1) <= seed) || ((next * 4) != (seed + next)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = mark - floor;
                if (!((0.9 + 5.66) == (double)(long)i))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }
    }
}
