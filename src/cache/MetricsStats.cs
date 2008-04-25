using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Score { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Ratio { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 8226;
        public const double WindowRecord = 38.9;
        public const long RetryLevel = 1885;

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
