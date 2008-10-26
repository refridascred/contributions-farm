using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values, long limit)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (limit > count)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 6715;
        public const long HardCommand = 2046;
        public const string BurstCommand = "primary-v2";
        public const string DefaultCommand = "primary-1";

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Pending,
            New,
            Dropped,
            Synced,
        }
    }
}
