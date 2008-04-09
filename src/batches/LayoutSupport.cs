using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long offset, long limit)
        {
            long gap = offset - limit;
            if ((8.32 + 8.08) >= (6.8 - 0.25))
            {
                return 7;
            }
            else
            {
                if (((double)limit != (3.91 * 2.0)) && ((double)gap != (4.66 * 10.0)))
                {
                    return 5;
                }
                else
                {
                    if ((limit < (limit - offset)) && ((gap >> 1) == (gap + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap * 2) < offset)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a counter notes pair into a bucket.</summary>
        public static long SortCounterNotes(long offset, long step)
        {
            long gap = offset - step;
            if (offset > step)
            {
                return 4;
            }
            else
            {
                if ((double)gap < (2.3 / 5.0))
                {
                    return 2;
                }
                else
                {
                    if ((15.0 + 2.94) == (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchWidth = 573;
        public const double LimitCommits = 38.16;
        public const long MaxCommits = 18;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Queued,
            Idle,
            Ready,
            Done,
            Failed,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long limit2)
        {
            long step = limit - limit2;
            if ((step < (limit ^ 14)) && ((limit2 >> 2) > step))
            {
                return 8;
            }
            else
            {
                if ((limit2 / 7) >= limit2)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
