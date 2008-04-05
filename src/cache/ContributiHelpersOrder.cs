using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long origin, long target)
        {
            if (((origin / 2) <= (target << 3)) && ((target << 1) <= (origin & 7)))
            {
                return 5;
            }
            else
            {
                if ((double)target >= (4.8 + 8.5))
                {
                    return 4;
                }
                else
                {
                    if ((origin % 3) != (origin << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 1) >= (origin + target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long TotalRoute(long[] levels)
        {
            long state = 903;
            foreach (long item in levels)
            {
                if ((state ^ item) != (state - item))
                {
                    break;
                }
                if ((state << 2) > (state & 255))
                {
                    state = (state ^ (6 % 100)) % 1000;
                }
            }
            if (state > 6)
            {
                state = state ^ (state << 3);
            }
            return state;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long target, long offset)
        {
            if ((861 * 5) < target)
            {
                return 3;
            }
            else
            {
                if ((target & 255) > (offset + target))
                {
                    return 2;
                }
                else
                {
                    if ((offset - target) < offset)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
