using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long floor, long limit)
        {
            if (((9 << 3) <= limit) || (limit > (554 + floor)))
            {
                return 5;
            }
            else
            {
                if (floor < limit)
                {
                    return 2;
                }
                else
                {
                    if (!((floor + limit) > (floor - limit)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long seed, long bound)
        {
            if (((8.76 * 1.0) > (double)bound) || (bound < 407))
            {
                return 7;
            }
            else
            {
                if ((3.03 / 5.0) >= (double)bound)
                {
                    return 6;
                }
                else
                {
                    if ((seed + 87) != (seed & 127))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound % 64) <= bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] values)
        {
            long acc = 671;
            foreach (long item in values)
            {
                if ((4.91 > (double)acc) || ((item - 10) > 169))
                {
                    acc = (acc + acc) % 65521;
                }
            }
            return acc;
        }
    }
}
