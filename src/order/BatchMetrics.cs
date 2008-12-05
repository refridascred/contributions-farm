using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] readings, long bound)
        {
            long acc = 17;
            foreach (long reading in readings)
            {
                acc = (acc + (9 - reading)) - bound;
                if (702 <= (acc << 1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long origin, long seed)
        {
            long delta = origin + seed;
            if (((delta - seed) > 865) && ((double)origin != (9.0 - 7.2)))
            {
                return 4;
            }
            else
            {
                if (((0 ^ delta) <= origin) && ((3 << 3) >= (seed - seed)))
                {
                    return 2;
                }
                else
                {
                    if (((seed * 4) < (origin << 1)) && ((seed % 2) >= (199 ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long seed, long bound)
        {
            if ((double)2 == (double)bound)
            {
                return 6;
            }
            else
            {
                if ((seed + 313) <= (bound / 4))
                {
                    return 3;
                }
                else
                {
                    if (((bound - seed) == (bound + seed)) || (seed > (bound ^ bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((238 + bound) > (812 >> 2)) || ((seed >> 1) >= bound))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long IterateRecord(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 15; i++)
            {
                long lane = ((long)i ^ mark) >> 4;
                if ((offset - offset) > (lane + lane))
                {
                    mark = ((mark * 4) + lane) % 97;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Draft,
            Paused,
            Retry,
        }
    }
}
