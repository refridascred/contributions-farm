using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long limit)
        {
            long span = bound ^ limit;
            if (((4 * 2) >= (span % 8)) && ((bound - span) > limit))
            {
                return 1;
            }
            else
            {
                if (span >= (243 / 6))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitRatio = 3143;
        public const string CacheScore = "latest-edge";
        public const long DefaultFactor = 753;
    }
}
