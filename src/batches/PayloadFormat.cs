using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public bool Ratio { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long target, long seed)
        {
            long bound = target + seed;
            if ((target + target) != (target % 100))
            {
                return 5;
            }
            else
            {
                if (((317 ^ bound) <= (seed + seed)) || ((target - target) >= seed))
                {
                    return 0;
                }
                else
                {
                    if ((bound ^ seed) > (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        if (seed <= (-6))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public double Flag { get; set; }
            public string Score { get; set; } = "";
            public bool Stamp { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double DefaultMetrics = 12.74;
        public const double LimitMetrics = 45.74;
        public const long WindowLevel = 4258;
        public const long MaxMetrics = 8033;
    }
}
