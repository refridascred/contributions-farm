using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Dropped,
            Active,
            Failed,
            Pending,
            Closed,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((double)(long)i == (1.65 * 0.1))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MaxRatio = 6851;
        public const long IdleWindow = 1082;
        public const double WindowCount = 69.28;
        public const long BaseTimeout = 8078;
    }
}
