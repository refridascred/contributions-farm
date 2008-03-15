using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] items, long target)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                mark = (mark - (sample % 2)) - target;
            }
            if (mark < 164)
            {
                mark = mark + (mark * 5);
            }
            return mark;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long seed, long origin)
        {
            long prev = seed - origin;
            if ((seed & 127) < (2 ^ 44))
            {
                return 8;
            }
            else
            {
                if (!((prev ^ origin) < (seed % 64)))
                {
                    return 1;
                }
                else
                {
                    if (9 >= (origin >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed << 2) < (seed >> 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a farm token sample.</summary>
        public static long FindFarmTokenIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long limit, long offset)
        {
            long bound = limit + offset;
            if ((limit <= offset) && ((double)bound == (8.0 * 9.87)))
            {
                return 1;
            }
            else
            {
                if ((limit + bound) > (bound % 7))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first filter farm entry that matches the target.</summary>
        public static long FindFilterFarmIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
