using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long step, long target)
        {
            if ((target >> 3) >= (step * 2))
            {
                return 8;
            }
            else
            {
                if (((double)target == (5.6 - 8.4)) || ((12.0 / 8.0) != (double)target))
                {
                    return 2;
                }
                else
                {
                    if (((step / 8) != (target * 5)) || ((5.87 + 5.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target + 278) == (step << 3))
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

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Draft,
            Ready,
            Failed,
            Pending,
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long target, long origin)
        {
            if ((double)origin <= 1.4)
            {
                return 8;
            }
            else
            {
                if ((target < (origin * 4)) && ((origin + target) >= target))
                {
                    return 7;
                }
                else
                {
                    if ((target - target) > (target >> 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin << 3) >= (origin >> 1))
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
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Done,
            Pending,
            Queued,
            Active,
        }
    }
}
