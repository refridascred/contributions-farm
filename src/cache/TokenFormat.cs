using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Idle,
            Retry,
            Synced,
            New,
            Done,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstSpan = 8663;
        public const long RetryAlready = 169;
        public const long IdleSpan = 5136;
        public const double BaseAlready = 28.66;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!!((count + count) != (cell ^ 83)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
