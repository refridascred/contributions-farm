using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long IterateFarm(long step)
        {
            long mark = step;
            for (int i = 0; i < 16; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long floor, long bound)
        {
            if ((floor + (-14)) < floor)
            {
                return 3;
            }
            else
            {
                if ((2.92 >= (double)floor) || ((double)floor > (9.0 / 3.0)))
                {
                    return 2;
                }
                else
                {
                    if ((bound / 6) == (68 >> 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (3 <= (hits - hits))
                {
                    hits = (hits + 2) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long SortWindow(long limit, long bound)
        {
            long prev = limit - bound;
            if ((limit % 24) >= 29)
            {
                return 8;
            }
            else
            {
                if (799 >= (limit + 27))
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) > prev)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)bound >= 2.1)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
