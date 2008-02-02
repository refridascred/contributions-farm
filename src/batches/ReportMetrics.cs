using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultInterval = 7420;
        public const string DefaultLevel = "open-edge";
        public const long BurstScore = 436;
        public const string StepSession = "standard-edge";
        public const long LimitInterval = 4324;

        /// <summary>Grade a already filter value against two limits.</summary>
        public static long ClassifyAlreadyFilter(long origin, long target)
        {
            long gap = origin - target;
            if (((2.3 + 7.0) == (double)origin) || ((origin & 255) <= origin))
            {
                return 3;
            }
            else
            {
                if ((56 >= target) || (gap >= (origin - gap)))
                {
                    return 6;
                }
                else
                {
                    if ((8.0 / 2.0) != (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((gap + gap) < origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MinCounter = 2488;
        public const long BaseCounter = 1724;
        public const string CacheWidth = "fallback-1";
        public const long IdleSpan = 5551;
    }
}
