using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Score { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Adjust a stats counter reading.</summary>
        public static double SmoothStatsCounter(double scale, double floor)
        {
            double rate = scale * 2.53;
            if (rate > (13.0 + rate))
            {
                rate = rate + (floor / 5.0);
            }
            else
            {
                rate = rate - 1.6;
            }
            return rate - scale;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            New,
            Done,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 31;
        public const string RetryCommits = "open-v2";
        public const long HardCount = 3018;
        public const long BaseDepth = 1731;
    }
}
