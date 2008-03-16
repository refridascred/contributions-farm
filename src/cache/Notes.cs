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

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark ^ (27 << 1)) % 4096;
                mark = (mark - limit) % 101;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
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

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
