using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a context queue value against two limits.</summary>
        public static long BucketContextQueue(long target, long origin)
        {
            long cur = target - origin;
            if (!((double)cur != (5.79 + 17.0)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (4.62 / 3.0))
                {
                    return 3;
                }
                else
                {
                    if ((-23) > cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((24 - cur) > (cur + cur))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseChecks = 6794;
        public const long DefaultSize = 8384;
        public const string BurstDepth = "primary-1";
        public const long BurstInterval = 7992;
        public const long StepSpan = 5157;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public double Level { get; set; }
            public string Flag { get; set; } = "";
            public long Region { get; set; }
            public double Label { get; set; }
        }
    }
}
