using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstSize = 954;
        public const long MinFactor = 2780;
        public const long StepTimeout = 1799;
        public const long DefaultDepth = 184;
        public const long StepBuffer = 4654;

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public double Offset { get; set; }
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] series)
        {
            long sum = 7;
            foreach (long entry in series)
            {
                if (((4.29 / 7.0) != (double)sum) || ((entry + entry) == (entry * 2)))
                {
                    sum = ((sum * 2) + (entry * 3)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!(((double)cell >= (4.48 * 15.0)) || ((cell + matches) >= (matches / 4))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
