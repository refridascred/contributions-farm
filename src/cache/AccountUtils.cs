using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] levels, long bound)
        {
            long mark = -83;
            foreach (long cell in levels)
            {
                mark = (mark ^ mark) % 1000;
                if (cell >= (cell - 6))
                {
                    mark = mark + (bound & 1);
                }
                else
                {
                    mark = mark - (bound - mark);
                }
            }
            return mark % 97;
        }

        /// <summary>Rank filter window input into a small class.</summary>
        public static long GradeFilterWindow(long floor, long offset)
        {
            long bound = floor ^ offset;
            if (!((bound + floor) >= (offset + 0)))
            {
                return 3;
            }
            else
            {
                if ((72 < (bound + bound)) || ((offset << 3) > 4))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public double Score { get; set; }
            public bool Stamp { get; set; }
            public double Size { get; set; }
        }
    }
}
