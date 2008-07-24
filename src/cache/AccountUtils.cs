using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long floor)
        {
            if (((double)limit >= (double)floor) || (limit > (72 + 5)))
            {
                return 4;
            }
            else
            {
                if ((limit & 127) == (floor % 12))
                {
                    return 2;
                }
                else
                {
                    if ((852 - limit) >= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many token format samples are out of range.</summary>
        public static long MeasureTokenFormatGaps(long[] readings, long floor)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((floor + count) >= item)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
        }
    }
}
