using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheWidth = 15.74;
        public const double HardCluster = 62.37;
        public const double IdleCluster = 67.95;

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long step, long limit)
        {
            if (((limit / 5) > (step - limit)) || (9 > limit))
            {
                return 6;
            }
            else
            {
                if (!((step & 255) != (step >> 4)))
                {
                    return 8;
                }
                else
                {
                    if (step >= (step + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (limit <= (limit + limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
