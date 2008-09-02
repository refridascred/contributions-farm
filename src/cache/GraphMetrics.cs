using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 23; i++)
            {
                if (319 > (sum & 255))
                {
                    sum = (sum ^ ((long)i * 5)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every counter metric entry stays within the limit.</summary>
        public static bool GuardCounterMetricLimits(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            New,
            Closed,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowInterval = 1.57;
        public const long MinLevel = 19;
        public const double MinDepth = 56.9;
        public const double HardBatches = 96.12;
        public const long MaxDepth = 5081;

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
