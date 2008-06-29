using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string WindowChecks = "legacy-v2";
        public const long BaseChecks = 7142;
        public const long IdleChecks = 2765;
        public const long BatchFactor = 7171;
        public const long RetryChecks = 4849;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Weight { get; set; }
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Grade a tools session value against two limits.</summary>
        public static long BucketToolsSession(long floor, long bound)
        {
            long gap = floor - bound;
            if ((gap - gap) > ((-445) - bound))
            {
                return 0;
            }
            else
            {
                if (floor >= bound)
                {
                    return 3;
                }
                else
                {
                    if ((7.9 / 2.0) >= (double)gap)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
