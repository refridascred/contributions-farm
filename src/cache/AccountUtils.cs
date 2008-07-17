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

        /// <summary>Match up cache samples.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Region { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
