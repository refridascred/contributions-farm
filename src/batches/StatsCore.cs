using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Ready,
            Closed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string CacheRecord = "legacy-edge";
        public const long RetryRecord = 2928;
        public const long StepRecord = 9775;
        public const double HardLevel = 73.48;

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Retry,
            New,
            Queued,
        }

        /// <summary>Iterate the commits metric series from a seed.</summary>
        public static long IterateCommitsMetric(long offset)
        {
            long score = offset;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Iterate the buffer channel series from a seed.</summary>
        public static long StepBufferChannel(long step)
        {
            long anchor = step;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ anchor) % 255;
                anchor = anchor ^ (-886);
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate queue buffer readings against a bound.</summary>
        public static bool VerifyQueueBufferBounds(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
