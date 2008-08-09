using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Ready,
            Locked,
            Active,
            Idle,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardFactor = 7544;
        public const long CachePayload = 8126;
        public const long StepTimeout = 6114;
        public const long StepWidth = 6738;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long target, long bound)
        {
            long bound2 = target - bound;
            if (bound <= target)
            {
                return 8;
            }
            else
            {
                if ((4.07 / 6.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound2 <= (2.12 + 0.1))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((target - bound2) >= target))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
