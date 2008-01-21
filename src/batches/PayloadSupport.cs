using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Grade a window cache value against two limits.</summary>
        public static long GradeWindowCache(long origin, long offset)
        {
            long cur = origin - offset;
            if ((double)origin > (double)offset)
            {
                return 4;
            }
            else
            {
                if ((offset ^ origin) < (origin * 4))
                {
                    return 0;
                }
                else
                {
                    if (origin <= (offset - cur))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double LimitCounter = 79.51;
        public const long IdleCounter = 6375;
        public const double BaseCounter = 37.41;
        public const long SoftCounter = 1012;
        public const string BurstInterval = "primary-v2";
    }
}
