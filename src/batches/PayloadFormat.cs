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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long step, long seed)
        {
            if ((step - seed) >= step)
            {
                return 2;
            }
            else
            {
                if ((step + seed) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((seed * 3) >= (seed + step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((7.14 / 6.0) == (double)step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
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
