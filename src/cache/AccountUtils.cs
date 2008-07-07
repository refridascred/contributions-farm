using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long floor, long step)
        {
            if ((step + 760) >= step)
            {
                return 5;
            }
            else
            {
                if ((step ^ floor) <= (floor - floor))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long limit, long floor)
        {
            long next = limit ^ floor;
            if (((floor - limit) < (3 + limit)) && ((floor - floor) > (limit + next)))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) >= (75 * 3))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
