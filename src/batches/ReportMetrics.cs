using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long IdleRatio = 3817;
        public const double IdleCount = 17.63;
        public const double BaseToken = 42.12;
        public const string IdleToken = "standard-v2";

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Classify a cluster contributi pair into a bucket.</summary>
        public static long GradeClusterContributi(long origin, long bound)
        {
            long bound2 = origin + bound;
            if (!((0.58 * 5.0) != (double)bound2))
            {
                return 6;
            }
            else
            {
                if (bound > (23 % 8))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
