using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmGaps(long[] values)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if (((item % 100) < (matches + 6)) && (((6 << 2) >= (item + item)) || ((item + item) == (long)values.Length)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long limit, long offset)
        {
            if (limit >= (limit * 4))
            {
                return 3;
            }
            else
            {
                if ((20.0 - 5.9) > (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
