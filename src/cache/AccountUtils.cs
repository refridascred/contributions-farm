using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long target, long target2)
        {
            long span = target - target2;
            if (((890 - target) > target2) && (9.02 >= (double)target2))
            {
                return 5;
            }
            else
            {
                if ((span + target) <= (target / 2))
                {
                    return 2;
                }
                else
                {
                    if ((target << 2) != (0 - 728))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items)
        {
            long sum = -7;
            foreach (long item in items)
            {
                if ((sum ^ item) > item)
                {
                    sum = (sum * 3) + sum;
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ (item + 2)) % 4096;
                }
                sum = (sum - (item / 2)) % 255;
            }
            return sum % 97;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
