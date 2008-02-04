using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string RetryMetrics = "local";
        public const double IdleSize = 67.58;
        public const long LimitMetrics = 8297;
        public const string WindowBudget = "fallback";

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] data)
        {
            long carry = -9;
            foreach (long sample in data)
            {
                if (((sample - sample) < 650) || (sample < (sample - 280)))
                {
                    carry = ((carry * 2) + carry) % 1000;
                }
            }
            if (carry > 591)
            {
                carry = (carry - (carry - carry)) % 101;
            }
            return carry;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
