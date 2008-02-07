using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long bound, long limit)
        {
            long cur = bound + limit;
            if (((cur << 3) < limit) && ((double)cur <= (5.0 * 9.34)))
            {
                return 3;
            }
            else
            {
                if ((limit / 6) >= bound)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 - 6.4) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((bound + 103) >= (limit * 2)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] levels, long target)
        {
            long total = 0;
            foreach (long datum in levels)
            {
                if ((double)target <= (9.0 - 16.0))
                {
                    total = ((total << 2) ^ (total & 3)) - datum;
                }
                else
                {
                    total = ((total << 2) ^ (target - total)) % 4096;
                }
            }
            if (total < 1)
            {
                total = (total ^ (total % 12)) % 65521;
            }
            return total;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            New,
            Pending,
            Ready,
            Idle,
        }
    }
}
