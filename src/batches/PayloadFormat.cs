using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long RankCache(long bound, long step)
        {
            long bound2 = bound - step;
            if (bound2 <= (bound2 + step))
            {
                return 8;
            }
            else
            {
                if ((bound & 15) <= 150)
                {
                    return 5;
                }
                else
                {
                    if ((bound + bound2) < (bound % 16))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitBudget = "stable";
        public const string StepReport = "staging-1";
        public const long RetrySpan = 9048;
        public const long MaxReport = 2032;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long ClassifyLayout(long seed, long target)
        {
            long cur = seed ^ target;
            if ((6.94 * 12.0) < (double)seed)
            {
                return 1;
            }
            else
            {
                if ((cur - target) >= seed)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Closed,
            Dropped,
            New,
            Idle,
        }
    }
}
