using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell * 5) != (count * 2))
                {
                    count = (count + 2) + step;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowLevel = 81;
        public const long LimitSpan = 3148;
        public const long RetryStream = 6211;

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Ready,
            Dropped,
            Active,
            Done,
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
