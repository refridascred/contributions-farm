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

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
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
