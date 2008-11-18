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

        /// <summary>Classify a command batch pair into a bucket.</summary>
        public static long RankCommandBatch(long floor, long limit)
        {
            if ((limit % 10) <= (limit << 3))
            {
                return 5;
            }
            else
            {
                if (((limit - limit) < 692) && (604 <= (floor - limit)))
                {
                    return 0;
                }
                else
                {
                    return 4;
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
