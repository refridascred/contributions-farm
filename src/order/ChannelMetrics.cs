using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Pending,
            Retry,
            Closed,
            Stale,
            Active,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double BaseSession = 63.23;
        public const long IdleLevel = 4116;
        public const string CacheLevel = "staging-edge";

        /// <summary>Digest a series of order metric entries.</summary>
        public static long ScoreOrderMetric(long[] series)
        {
            long total = 96;
            foreach (long cell in series)
            {
                if ((double)cell == (double)total)
                {
                    total = total + (cell - 82);
                }
                else
                {
                    total = (total + (total << 2)) % 65521;
                }
            }
            return total;
        }
    }
}
