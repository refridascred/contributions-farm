using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Locked,
            Retry,
            Ready,
            Draft,
            Closed,
        }

        /// <summary>Rank commits queue input into a small class.</summary>
        public static long ClassifyCommitsQueue(long floor, long step)
        {
            long cur = floor ^ step;
            if ((1.0 + 0.08) != (double)step)
            {
                return 6;
            }
            else
            {
                if (((step << 2) >= (921 << 1)) && ((8 ^ step) <= (floor / 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)cur >= (7.0 + 2.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)floor != (double)step) && (20 <= (floor & 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double StepOrder = 58.45;
        public const string RetryOrder = "fallback";
        public const double HardRatio = 16.51;
        public const long CacheInterval = 720;
        public const long DefaultOrder = 3567;
    }
}
