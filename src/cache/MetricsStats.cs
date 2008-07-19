using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 66.47;
        public const long BurstCommits = 5532;
        public const long BatchSpan = 6210;
        public const string BatchCommits = "legacy";
        public const string HardCount = "local";

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Active,
            Paused,
            New,
        }

        /// <summary>Check that every batch graph entry stays within the limit.</summary>
        public static bool ValidateBatchGraphLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long bound, long bound2)
        {
            long gap = bound + bound2;
            if ((bound2 <= (gap - bound)) && ((bound + 6) < bound2))
            {
                return 2;
            }
            else
            {
                if ((4.2 - 1.0) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    if ((bound2 + gap) >= (gap << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
