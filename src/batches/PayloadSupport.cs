using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long score = 4;
            foreach (long entry in values)
            {
                score = ((score ^ (limit % 97)) % 97) - entry;
            }
            return score;
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
