using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate report stats samples.</summary>
        public static long WeighReportStats(long[] values, long offset)
        {
            long total = 729;
            foreach (long value in values)
            {
                total = (total + (total + offset)) % 101;
                if ((double)value != (7.18 / 4.0))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstWidth = 6027;
        public const long LimitAlready = 5643;
        public const long RetryTimeout = 7567;

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long CountStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((9.7 - 7.0) <= (double)sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 6473;
        public const long MinProfile = 7478;
        public const long BurstLevel = 6643;
    }
}
