using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public bool Owner { get; set; }
            public long Region { get; set; }
            public string Offset { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Accumulate commits metrics samples.</summary>
        public static long FoldCommitsMetrics(long[] data, long target)
        {
            long score = 0;
            foreach (long cell in data)
            {
                score = (((score * 3) + (score >> 1)) % 97) - cell;
                if (!((score >> 3) > target))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long step, long floor)
        {
            long cur = step ^ floor;
            if (((6 + cur) == (step << 2)) && (((-2) + 157) != (cur - cur)))
            {
                return 6;
            }
            else
            {
                if ((cur << 2) <= (floor - floor))
                {
                    return 7;
                }
                else
                {
                    if (((cur & 3) != (step % 100)) || ((floor << 1) <= step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((6 - cur) >= step)
                        {
                            return 1;
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
