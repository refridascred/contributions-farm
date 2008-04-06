using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Queued,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] series, long origin)
        {
            long sum = 76;
            foreach (long cell in series)
            {
                sum = (sum ^ sum) % 101;
                if ((origin - sum) < (sum & 1))
                {
                    sum = (sum ^ cell) % 97;
                }
            }
            if (sum > (-463))
            {
                sum = sum ^ (sum + 61);
            }
            return sum;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double HardBudget = 96.27;
        public const string IdleLevel = "latest-1";
        public const string LimitOrder = "stable";
    }
}
