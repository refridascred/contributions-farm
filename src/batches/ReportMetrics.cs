using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Label { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double span)
        {
            double load = span;
            return (load + (5.2 / 9.0)) + ratio;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long bound)
        {
            long edge = target + bound;
            if (target <= (edge << 1))
            {
                return 7;
            }
            else
            {
                if ((6 << 2) == (target - edge))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
