using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Idle,
            Dropped,
            Closed,
            Locked,
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long offset)
        {
            long offset2 = bound + offset;
            if ((double)offset2 <= (4.1 * 6.4))
            {
                return 5;
            }
            else
            {
                if ((offset <= (offset << 1)) || (offset >= (bound << 1)))
                {
                    return 4;
                }
                else
                {
                    if (!((offset2 << 2) > (offset / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((45 % 97) < offset2)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TotalMetric(long[] values)
        {
            long mark = 9;
            foreach (long value in values)
            {
                if (((9.6 - 6.12) >= (double)value) || ((14 + value) > (6 % 24)))
                {
                    mark = (mark * 3) + (mark - mark);
                }
                if (!(mark < (mark >> 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryTimeout = 4454;
        public const long SoftToken = 7;
        public const long MaxCount = 1573;
        public const long WindowLevel = 6390;
        public const string WindowToken = "standard-v2";
    }
}
