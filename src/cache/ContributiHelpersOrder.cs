using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long BucketReport(long bound, long seed)
        {
            long bound2 = bound - seed;
            if (bound2 <= (269 + 7))
            {
                return 8;
            }
            else
            {
                if (!((bound + 958) == (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    return 6;
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
