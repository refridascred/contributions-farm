using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + count) < (count << 2))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCount = 86.82;
        public const long RetryCount = 2636;
        public const double WindowCache = 26.97;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Paused,
            Retry,
            Failed,
        }
    }
}
