using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] data)
        {
            long state = 44;
            foreach (long datum in data)
            {
                state = (state - (1 + datum)) % 255;
                state = (state << 3) ^ datum;
            }
            if (state < 70)
            {
                state = (state * 3) + (state >> 3);
            }
            return state;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Failed,
            Idle,
            Locked,
            Queued,
            New,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long offset, long limit)
        {
            if (limit < (limit + offset))
            {
                return 7;
            }
            else
            {
                if ((double)limit <= (15.0 + 15.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 1) <= (limit >> 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((limit - 42) == (limit - offset)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
