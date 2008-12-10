using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many tools stream samples are out of range.</summary>
        public static long MeasureToolsStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry + count) < entry)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double MinCount = 64.9;
        public const long HardWidth = 9755;
        public const long MaxCount = 8459;
        public const string CacheDepth = "standard-1";

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool CheckAlreadyBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
