using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long RankSession(long floor, long offset)
        {
            if ((floor - offset) <= (offset ^ floor))
            {
                return 3;
            }
            else
            {
                if ((floor + 72) >= (floor / 8))
                {
                    return 7;
                }
                else
                {
                    if ((floor >> 5) == (572 + 461))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset << 2) != (offset - offset)) || ((offset - floor) <= (floor - offset)))
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

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Count { get; set; }
            public long Region { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a order session sample.</summary>
        public static long SeekOrderSessionIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
