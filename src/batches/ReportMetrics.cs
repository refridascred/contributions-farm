using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a profile value against two limits.</summary>
        public static long SortProfile(long limit, long seed)
        {
            long span = limit + seed;
            if ((span + seed) != (span - limit))
            {
                return 3;
            }
            else
            {
                if (((span - span) >= (span + 4)) && ((span - seed) > limit))
                {
                    return 2;
                }
                else
                {
                    if (((-5) & 63) == (72 + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string DefaultMetrics = "alpha-1";
        public const string IdleMetrics = "fallback-1";
        public const double StepLevel = 71.74;
        public const long BurstLevel = 1579;
        public const string WindowMetrics = "alpha-1";

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Idle,
            Failed,
            Ready,
            Stale,
            Active,
        }
    }
}
