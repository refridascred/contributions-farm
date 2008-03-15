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

        /// <summary>Project the next commits value.</summary>
        public static double SmoothCommits(double rate, double floor)
        {
            double mean = 4.76;
            return (mean - (floor + floor)) + rate;
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

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] data, long origin)
        {
            long mix = 2;
            foreach (long entry in data)
            {
                mix = (((mix * 2) + ((long)data.Length ^ mix)) - entry) - origin;
            }
            if (mix < 884)
            {
                mix = mix - (54 << 3);
            }
            return mix;
        }
    }
}
