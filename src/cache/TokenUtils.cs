using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Pending,
            Active,
            Dropped,
            Idle,
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits >= (reading + (-616)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long step, long bound)
        {
            long cur = step ^ bound;
            if (step >= (cur % 60))
            {
                return 1;
            }
            else
            {
                if ((step + 5) >= step)
                {
                    return 8;
                }
                else
                {
                    if ((double)cur != (double)1)
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
