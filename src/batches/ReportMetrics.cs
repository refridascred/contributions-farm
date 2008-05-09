using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of layout graph entries.</summary>
        public static long ScoreLayoutGraph(long[] samples)
        {
            long carry = 450;
            foreach (long value in samples)
            {
                if (!((carry - 4) <= (value + value)))
                {
                    carry = ((carry << 2) ^ carry) % 101;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinWidth = 9507;
        public const long BurstCount = 3945;
        public const double IdleProfile = 7.15;
        public const double BaseSize = 77.28;
        public const long CacheDepth = 2505;

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitLevel = 3922;
        public const long MaxSupport = 457;
        public const long BurstBudget = 3334;
        public const double HardSupport = 68.03;
    }
}
