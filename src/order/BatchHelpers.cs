using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitTimeout = 6949;
        public const double StepDepth = 73.76;
        public const long BurstBuffer = 1884;
        public const long BatchTimeout = 3202;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Level { get; set; } = "";
            public bool Score { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long floor, long bound)
        {
            if (!((68 >> 5) != (floor & 7)))
            {
                return 5;
            }
            else
            {
                if (((3 >> 2) < (bound >> 1)) || ((double)floor < (19.0 - 6.84)))
                {
                    return 3;
                }
                else
                {
                    if (bound >= (floor * 2))
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
    }
}
