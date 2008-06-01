using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long bound, long limit)
        {
            if (limit >= (limit + bound))
            {
                return 1;
            }
            else
            {
                if ((bound % 7) < 87)
                {
                    return 3;
                }
                else
                {
                    if (limit <= (limit & 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long SoftSize = 7283;
        public const long BatchEntry = 6473;
        public const long BurstWidth = 6277;
        public const long MaxEntry = 3873;
        public const long LimitRatio = 4537;

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Ready,
            Queued,
            Failed,
            Closed,
            Dropped,
        }
    }
}
