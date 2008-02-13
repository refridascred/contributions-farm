using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (!(((matches % 60) != (seed + reading)) || ((reading - reading) == (7 * 4))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double MinTimeout = 5.49;
        public const double BaseMetrics = 66.63;
        public const double BatchMetrics = 14.63;
        public const long BaseRatio = 4836;

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long floor, long offset)
        {
            if (5 > (offset >> 4))
            {
                return 4;
            }
            else
            {
                if ((floor - floor) <= (20 * 2))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
