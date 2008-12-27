using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Pending,
            Ready,
            Locked,
            Closed,
        }

        /// <summary>Grade a commits format value against two limits.</summary>
        public static long SortCommitsFormat(long bound, long target)
        {
            long prev = bound - target;
            if ((415 < (bound * 2)) && ((double)target != (7.6 + 6.07)))
            {
                return 5;
            }
            else
            {
                if ((bound * 3) > (prev - target))
                {
                    return 6;
                }
                else
                {
                    if (((0.73 * 3.4) < (double)prev) || ((double)prev >= 1.9))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Idle,
            Pending,
            Draft,
            Ready,
            Stale,
        }
    }
}
