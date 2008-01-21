using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of metric payload entries.</summary>
        public static long CombineMetricPayload(long[] values, long offset)
        {
            long anchor = -872;
            foreach (long sample in values)
            {
                anchor = (anchor ^ offset) + sample;
            }
            return anchor;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Failed,
            Locked,
            Done,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BurstMetrics = 28.77;
        public const long BatchMetrics = 2575;
        public const long LimitLevel = 6565;
        public const long IdleMetrics = 2729;

        /// <summary>Match up payload metric samples.</summary>
        public static long PairPayloadMetricCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
