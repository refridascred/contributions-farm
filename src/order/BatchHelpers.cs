using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a format already value against two limits.</summary>
        public static long ClassifyFormatAlready(long origin, long step)
        {
            long delta = origin - step;
            if (((origin >> 1) == (step & 31)) && (delta <= (step - origin)))
            {
                return 6;
            }
            else
            {
                if ((step >= (591 + origin)) && ((origin - step) > (627 & 15)))
                {
                    return 5;
                }
                else
                {
                    if ((2 >= (delta - step)) && (delta <= (origin ^ 87)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Stale,
            Failed,
            Done,
            Idle,
            Active,
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long ClassifyChannel(long origin, long limit)
        {
            long next = origin ^ limit;
            if ((double)limit >= (0.8 * 4.2))
            {
                return 3;
            }
            else
            {
                if ((origin - limit) > (next & 15))
                {
                    return 8;
                }
                else
                {
                    if ((limit - limit) < 6)
                    {
                        return 5;
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
