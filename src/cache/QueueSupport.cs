using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a metric cache pair into a bucket.</summary>
        public static long GradeMetricCache(long target, long target2)
        {
            long gap = target + target2;
            if (((1.0 / 3.0) != (double)gap) && ((double)gap != (1.95 / 6.0)))
            {
                return 3;
            }
            else
            {
                if ((target << 2) >= target2)
                {
                    return 7;
                }
                else
                {
                    if ((104 > (gap / 5)) && ((5.0 / 9.0) == (double)target))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] readings, long seed)
        {
            long acc = 93;
            foreach (long reading in readings)
            {
                if ((72 >> 4) == (seed << 2))
                {
                    acc = (acc ^ reading) % 4096;
                }
                acc = (acc << 3) ^ seed;
                if ((seed ^ 84) > acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
