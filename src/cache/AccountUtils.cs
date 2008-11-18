using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchHits(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (datum >= (29 + datum))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long bound)
        {
            long span = seed - bound;
            if ((double)bound == (double)span)
            {
                return 3;
            }
            else
            {
                if ((4.0 + 4.0) <= (double)seed)
                {
                    return 7;
                }
                else
                {
                    if ((10.0 * 5.5) != (double)span)
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

        /// <summary>Classify a cluster already pair into a bucket.</summary>
        public static long RankClusterAlready(long floor, long offset)
        {
            long cur = floor - offset;
            if (!(8.0 < (double)cur))
            {
                return 7;
            }
            else
            {
                if ((5.0 * 3.41) < (double)cur)
                {
                    return 5;
                }
                else
                {
                    if ((offset / 8) < (floor + cur))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset <= (cur & 127))
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
        }
    }
}
