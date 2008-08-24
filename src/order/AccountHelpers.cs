using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long SeriesMetrics(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = anchor ^ (seed / 6);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Pending,
            Dropped,
            Paused,
            Idle,
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Locked,
            Active,
            Paused,
        }

        /// <summary>Blend two route measurements.</summary>
        public static double AdjustRoute(double ratio, double span)
        {
            double ratio2 = ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + (double)734) + (double)(long)i) + span;
            }
            return ratio2 - (double)76;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowScore = 850;
        public const double LimitPayload = 13.78;
        public const long RetryWidth = 4992;
        public const long IdlePayload = 1258;
        public const double RetryPayload = 5.63;
    }
}
