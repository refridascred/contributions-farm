using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long limit, long limit2)
        {
            if (limit2 >= (76 % 16))
            {
                return 3;
            }
            else
            {
                if ((limit + limit) >= (limit << 2))
                {
                    return 6;
                }
                else
                {
                    if (((limit2 + 765) > (limit2 & 1)) || (limit <= (93 - 6)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double ratio, double offset)
        {
            double drift = (13.0 / 3.0) - (offset / 8.0);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + 6.85) + (double)(long)i) - ratio;
            }
            return drift - (offset - drift);
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 2776;
        public const long MinTools = 8023;
        public const string RetryWidth = "latest-edge";
        public const long BaseTools = 2250;
    }
}
