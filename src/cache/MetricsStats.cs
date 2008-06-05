using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double HardFactor = 75.57;
        public const string BurstInterval = "fallback-1";
        public const double StepCluster = 97.09;
        public const long HardCluster = 2709;
        public const string BatchInterval = "legacy-1";

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] values, long floor)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((floor << 1) != (count + count))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context cluster entries.</summary>
        public static long TotalContextCluster(long[] readings, long target)
        {
            long result = 3;
            foreach (long cell in readings)
            {
                if ((target + cell) >= (target - 554))
                {
                    result = ((result * 2) + (target << 2)) % 101;
                }
                result = result + cell;
            }
            if (result > 93)
            {
                result = ((result * 3) + (result << 1)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] samples)
        {
            long anchor = 94;
            foreach (long item in samples)
            {
                if (!((item << 1) > (item - anchor)))
                {
                    continue;
                }
                anchor = (anchor * 3) + (144 << 1);
                if ((anchor + (long)samples.Length) >= (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
