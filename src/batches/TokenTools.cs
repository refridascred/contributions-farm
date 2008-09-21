using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryProfile = 1712;
        public const long StepProfile = 9484;
        public const long MaxProfile = 3612;
        public const long HardProfile = 1219;

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public double Total { get; set; }
            public bool Label { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long offset, long limit)
        {
            if ((offset / 5) == (898 & 3))
            {
                return 8;
            }
            else
            {
                if (offset > (offset << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset + limit) <= (limit - offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
