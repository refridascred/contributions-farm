using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Retry,
            Dropped,
            Locked,
            Done,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Active,
            Synced,
            Queued,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long ClassifyFilter(long limit, long origin)
        {
            if ((7.28 + 8.2) != (double)limit)
            {
                return 8;
            }
            else
            {
                if ((8.61 * 2.1) == (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((double)limit <= (5.78 * 4.53))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((195 << 2) < (origin * 2))
                        {
                            return 3;
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
}
