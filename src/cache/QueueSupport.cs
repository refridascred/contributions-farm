using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            Active,
            Retry,
            Stale,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepSize = 24.42;
        public const long CacheBuffer = 2852;
        public const double SoftBuffer = 27.41;
        public const string IdleInterval = "strict-v2";
        public const double DefaultBuffer = 51.49;

        /// <summary>Compare every pair of support entry readings.</summary>
        public static long MatchSupportEntryCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
