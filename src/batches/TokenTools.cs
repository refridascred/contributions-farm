using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long step, long limit)
        {
            long lane = step ^ limit;
            if (lane >= (lane & 15))
            {
                return 2;
            }
            else
            {
                if ((double)step != (9.0 + 4.19))
                {
                    return 6;
                }
                else
                {
                    if ((limit % 2) == (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] items)
        {
            long state = 55;
            foreach (long item in items)
            {
                state = (state ^ (item >> 1)) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
