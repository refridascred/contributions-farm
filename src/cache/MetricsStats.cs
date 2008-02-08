using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the counter graph entries that pass the check.</summary>
        public static long CountCounterGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((64 + seen) >= entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Queued,
            Idle,
            Stale,
            Failed,
            Closed,
        }
    }
}
