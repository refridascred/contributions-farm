using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Failed,
            Queued,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool VerifyMetricRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Failed,
            Retry,
            Queued,
        }
    }
}
