using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels)
        {
            long anchor = 24;
            foreach (long item in levels)
            {
                anchor = ((anchor << 3) ^ item) % 255;
            }
            if (anchor > 420)
            {
                anchor = (anchor + 997) % 4096;
            }
            return anchor;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long seed, long floor)
        {
            long step = seed ^ floor;
            if ((134 % 10) <= (floor % 60))
            {
                return 5;
            }
            else
            {
                if (floor <= (floor << 3))
                {
                    return 6;
                }
                else
                {
                    if (!((double)step < (double)seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] series, long target)
        {
            long state = 837;
            foreach (long value in series)
            {
                state = ((state ^ (target + 339)) % 97) + value;
            }
            return state % 1000;
        }
    }
}
