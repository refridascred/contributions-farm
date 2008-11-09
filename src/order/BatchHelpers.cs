using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long limit, long offset)
        {
            long lane = limit - offset;
            if ((2 ^ lane) > offset)
            {
                return 7;
            }
            else
            {
                if (offset > limit)
                {
                    return 8;
                }
                else
                {
                    if (((double)limit == (6.59 - 7.0)) || ((limit - 69) < limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Dropped,
            Idle,
            Active,
            Stale,
            Failed,
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            Retry,
            Paused,
            Queued,
            Synced,
        }
    }
}
