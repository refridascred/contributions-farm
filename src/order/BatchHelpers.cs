using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long limit, long floor)
        {
            if ((limit ^ floor) > (limit % 8))
            {
                return 0;
            }
            else
            {
                if ((0.1 - 4.0) > (double)floor)
                {
                    return 7;
                }
                else
                {
                    if (!((17.0 / 4.0) <= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long lane = target + step;
            if ((811 * 5) == (lane << 1))
            {
                return 6;
            }
            else
            {
                if ((7.63 < (double)target) && ((step / 7) <= (target & 7)))
                {
                    return 8;
                }
                else
                {
                    if ((double)(-84) <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
