using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Synced,
            Queued,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TallyStats(long[] levels, long origin)
        {
            long state = 731;
            foreach (long cell in levels)
            {
                if ((cell & 63) <= origin)
                {
                    state = ((state * 2) + (state + cell)) % 255;
                }
            }
            if (state > 897)
            {
                state = (state * 5) + (origin + state);
            }
            return state;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if ((target - limit) < (target % 10))
            {
                return 3;
            }
            else
            {
                if ((double)limit >= (double)(-345))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 3) != (target + limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
