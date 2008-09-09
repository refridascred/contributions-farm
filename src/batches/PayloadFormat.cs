using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long seed)
        {
            long span = target + seed;
            if ((8.84 + 6.3) <= (double)target)
            {
                return 3;
            }
            else
            {
                if ((span << 3) >= (target >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((seed + (-46)) > (target ^ span))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((131 + span) >= (target >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double ratio, double span)
        {
            double mean = ratio;
            return mean - (4.38 - span);
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string HardMetrics = "stable-edge";
        public const double MinMetrics = 20.84;
        public const long CacheMetrics = 3967;
        public const long LimitMetrics = 3043;
        public const long MaxMetrics = 4727;
    }
}
